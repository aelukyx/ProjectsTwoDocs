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
    public class AlquilerController : Controller
    {
        //
        // GET: /Alquiler/

        private readonly SistraturEntities entities;

        private readonly IAlquilerService service;
        public AlquilerController(IAlquilerService service)
        {
            this.service = service;
            this.entities = new SistraturEntities();
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index", service.All());
        }

        [HttpGet]
        public ActionResult Create()
        {
            var vehiculos = service.TraerVehiculos();
            var conductores = service.TraerConductores();
            var perfiles = service.TraerPerfilUsuarios();
            var clientes = service.TraerClientes();

            List<object> clientesDef = new List<object>();
            foreach (var _cliente in clientes)
                clientesDef.Add(new
                {
                    Id = _cliente.Id,
                    Denominacion =_cliente.NombresRazonSocial + " " + _cliente.AppPaterno + " " + _cliente.AppMaterno
                });

            ViewData["ClienteId"] = new SelectList(clientesDef, "Id", "Denominacion");
            ViewData["VehiculoId"] = new SelectList(vehiculos, "Id", "Placa");
            ViewData["ConductorId"] = new SelectList(conductores, "Id", "NombreCompleto");
            ViewData["PerfilUsuarioId"] = new SelectList(perfiles, "Id", "Username");

            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Alquiler alquiler)
        {
            if (ModelState.IsValid)
            {
                var clientes = service.TraerClientes();
                var vehiculos = service.TraerVehiculos();
                var conductores = service.TraerConductores();
                var perfiles = service.TraerPerfilUsuarios();

                var options = service.TraerClientes()
                    .Where(x => x.Id == alquiler.ClienteId)
                    .Select(x => new { Value = x.Id, Text = x.NombresRazonSocial + " - " + x.AppPaterno });

                ViewData["ClienteId"] = new SelectList(options, "Value", "Text");

                var members = service.TraerClientes();
                List<object> newList = new List<object>();
                foreach (var member in members)
                    newList.Add(new
                    {
                        Id = member.Id,
                        Name = member.AppPaterno + " " + member.AppMaterno
                    });

                ViewData["Members"] = new SelectList(newList, "Id", "Name");


                ViewData["VehiculoId"] = new SelectList(vehiculos, "Id", "Placa");
                ViewData["ConductorId"] = new SelectList(conductores, "Id", "NombreCompleto");
                ViewData["PerfilUsuarioId"] = new SelectList(perfiles, "Id", "Username");

                service.Insert(alquiler);
                return RedirectToAction("Index");
            }

            return View("Create");
        }

    }
}
