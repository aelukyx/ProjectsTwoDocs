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
    public class ProveedorController : Controller
    {

        private readonly IProveedorService service;

        public ProveedorController(IProveedorService service)
        {
            this.service = service;
        }

        // GET: Proveedor

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index", service.All());
        }

        [HttpGet]
        public ActionResult Create()
        {
            var ciudades = service.TraerCiudades();

            ViewData["CiudadId"] = new SelectList(ciudades, "Id", "Descripcion");

            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                using (var db = new SistraturEntities())
                {
                    Proveedor ruc = db.Proveedores.FirstOrDefault(u => u.Ruc.ToLower() == proveedor.Ruc.ToLower());
                    if (ruc == null)
                    {
                        var ciudades = service.TraerCiudades();

                        ViewData["CiudadId"] = new SelectList(ciudades, "Id", "Descripcion");

                        service.Insert(proveedor);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("Ruc", "Este Nro. de RUC ya Existe!!");
                    }
                }

            }

            return View("Create");
        }
    }
}
