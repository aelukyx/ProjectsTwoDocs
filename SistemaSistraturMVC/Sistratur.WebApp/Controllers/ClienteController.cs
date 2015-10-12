using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Details(int id)
        {
            return View();
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
                        ModelState.AddModelError("NroDocumento", "Este Nro. de Documento ya Existe!!");
                    }
                }
            }

            return View("Create");
        }
        
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
