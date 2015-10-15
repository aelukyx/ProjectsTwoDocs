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
    public class VehiculoController : Controller
    {
        //
        // GET: /Vehiculo/

        private readonly IVehiculoService service;

        public VehiculoController(IVehiculoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index", service.All());
        }

        [HttpGet]
        public ActionResult Create()
        {
            var combustibles = service.TraerCombustibles();
            var estados = service.TraerEstadosVehiculos();
            var tipos = service.TraerTiposVehiculos();
            var modelos = service.TraerModelos();
            var colores = service.TraerColores();
            var marcas = service.TraerMarcasVehiculo();

            ViewData["CombustibleId"] = new SelectList(combustibles, "Id", "Descripcion");
            ViewData["EstadoVehiculoId"] = new SelectList(estados, "Id", "Descripcion");
            ViewData["MarcaVehiculoId"] = new SelectList(marcas, "Id", "Descripcion");
            ViewData["ModeloId"] = new SelectList(modelos, "Id", "Descripcion");
            ViewData["ColorId"] = new SelectList(colores, "Id", "Descripcion");
            ViewData["TipoId"] = new SelectList(tipos, "Id", "Descripcion");

            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Vehiculo vehiculo)
        {
            service.Insert(vehiculo);
            return RedirectToAction("Index");
        }


    }
}
