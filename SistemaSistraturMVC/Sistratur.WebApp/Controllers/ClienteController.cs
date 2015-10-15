using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

using Sistratur.Interfaces.Servicios;
using Sistratur.Modelos.Modelos;
using Sistratur.Servicios.Servicios;
using Sistratur.BaseDeDatos.Modelado;
using Sistratur.BaseDeDatos.Mapeado;

namespace Sistratur.WebApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService service;
        public ClienteController(IClienteService service)
        {
            this.service = service;
        }

        // GET: Cliente
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index", service.All());
        }

        // GET: Cliente/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            if (id == 0)
                return RedirectToAction("Index");
            return View("Details", service.TraerPorId(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                using (var db = new SistraturEntities())
                {
                    Cliente doc = db.Clientes.FirstOrDefault(u => u.NroDocumento.ToLower() == cliente.NroDocumento.ToLower());
                    if (doc == null)
                    {
                        service.Insert(cliente);
                        return RedirectToAction("Index", "Cliente");
                    }
                    else
                    {
                        ModelState.AddModelError("NroDocumento", "Este Nro. de Documento ya existe.");
                    }
                }
            }

            return View(cliente);

        }

        public ActionResult Edit(int id)
        {
            var model = service.TraerPorId(id);
            return View("Edit", model);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                service.Update(cliente);
                return RedirectToAction("Index");
            }
            return View("Edit", cliente);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}


//if ((cliente.TipoDocumento == false) && (cliente.NroDocumento.Length != 11))
//{
//    ModelState.AddModelError("NroDocumento", "Verifique que el Nro. de Documento poesea 11 digitos.");
//}