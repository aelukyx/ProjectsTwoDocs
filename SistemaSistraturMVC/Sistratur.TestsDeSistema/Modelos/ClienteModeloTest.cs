using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.WebApp.Controllers;
using Sistratur.Interfaces.Servicios;
using Sistratur.Modelos.Modelos;
using Sistratur.Servicios.Servicios;
using Moq;
using NUnit.Framework;
using System.Data.Entity;
using System.Web.Mvc;


namespace Sistratur.TestsDeSistema.Modelos
{
    [TestFixture]
    public class ClienteModeloTest
    {

        [Test]
        public void _01_CienteValidoMinimoRequerimeintos()
        {

            //arrage
            var mock = new Mock<IClienteService>();
            var controller = new ClienteController(mock.Object);
            var customer = new Cliente {
                TipoDocumento = true,
                NroDocumento = "75784521458",
                NombresRazonSocial = "Jardín San Antonio",
                Celular = "978267995",
                Direccion = "Jr. Los Pinos # 487",
                Email = "jsanantonio@hotmail.com",
                FechaRegistro = Convert.ToDateTime("05/07/2015")
            };
            controller.ValidateModel(customer);

            var redirectRoute = controller.Create(customer) as RedirectToRouteResult;

            //Afirmar - Assert
            Assert.IsNotNull(redirectRoute);
            Assert.AreEqual("Index", redirectRoute.RouteValues["action"]);
            Assert.AreEqual("Cliente", redirectRoute.RouteValues["controller"]);
        }

        [Test]
        public void _01_ClienteInvalidoFalloFormatoEmail()
        {
            //arrage
            var mock = new Mock<IClienteService>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());

            var controller = new ClienteController(mock.Object);
            var customer = new Cliente
            {
                TipoDocumento = true,
                NroDocumento = "75784521458",
                NombresRazonSocial = "Jardín San Antonio",
                Celular = "978267995",
                Direccion = "Jr. Los Pinos # 487",
                Email = "jsanantonio@", 
                FechaRegistro = Convert.ToDateTime("05/07/2015")
            };
            controller.ValidateModel(customer);


            var viewResult = controller.Create(customer) as ViewResult;

            //Afirmar - Assert
            Assert.IsNotNull(viewResult);
            Assert.AreEqual(string.Empty, viewResult.ViewName);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
        }

        [Test]
        public void _02_ClienteInvalidoFalloFormatoCelular()
        {
            //arrage
            var mock = new Mock<IClienteService>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());

            var controller = new ClienteController(mock.Object);
            var customer = new Cliente
            {
                TipoDocumento = true,
                NroDocumento = "71621467",
                NombresRazonSocial = "Jardín San Antonio",
                Celular = "506349",
                Direccion = "Jr. Los Pinos # 487",
                Email = "jsanantonio@hotmail.com",
                FechaRegistro = Convert.ToDateTime("05/07/2015")
            };
            controller.ValidateModel(customer);


            var viewResult = controller.Create(customer) as ViewResult;

            //Afirmar - Assert
            Assert.IsNotNull(viewResult);
            Assert.AreEqual(string.Empty, viewResult.ViewName);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
        }

        [Test]
        public void _03_ClienteInvalidoFalloNroDocumentoNull()
        {
            //arrage
            var mock = new Mock<IClienteService>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());

            var controller = new ClienteController(mock.Object);
            var customer = new Cliente
            {
                TipoDocumento = true,
                NroDocumento = null,
                NombresRazonSocial = "Jardín San Antonio",
                Celular = "978267995",
                Direccion = "Jr. Los Pinos # 487",
                Email = "jsanantonio@hotmail.com",
                FechaRegistro = Convert.ToDateTime("05/07/2015")
            };
            controller.ValidateModel(customer);


            var viewResult = controller.Create(customer) as ViewResult;

            //Afirmar - Assert
            Assert.IsNotNull(viewResult);
            Assert.AreEqual(string.Empty, viewResult.ViewName);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
        }

        [Test]
        public void _04_ClienteInvalidoTelefonoSolo5Digitos()
        {

            //arrage
            var mock = new Mock<IClienteService>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());

            var controller = new ClienteController(mock.Object);
            var customer = new Cliente
            {
                TipoDocumento = true,
                NroDocumento = "71621467",
                NombresRazonSocial = "Jardín San Antonio",
                Celular = "978267995",
                Direccion = "Jr. Los Pinos # 487",
                Telefono = "36052",
                Email = "jsanantonio@hotmail.com",
                FechaRegistro = Convert.ToDateTime("05/07/2015")
            };
            controller.ValidateModel(customer);


            var viewResult = controller.Create(customer) as ViewResult;

            //Afirmar - Assert
            Assert.IsNotNull(viewResult);
            Assert.AreEqual(string.Empty, viewResult.ViewName);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
        }

        [Test]
        public void _05_ClienteInvalidoFalloFormatoEmail()
        {
            //arrage
            var mock = new Mock<IClienteService>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());

            var controller = new ClienteController(mock.Object);
            var customer = new Cliente
            {
                TipoDocumento = true,
                NroDocumento = "75784521458",
                NombresRazonSocial = "Jardín San Antonio",
                Celular = "978267995",
                Direccion = "Jr. Los Pinos # 487",
                Email = "jsanantonio@",
                FechaRegistro = Convert.ToDateTime("05/07/2015")
            };
            controller.ValidateModel(customer);


            var viewResult = controller.Create(customer) as ViewResult;

            //Afirmar - Assert
            Assert.IsNotNull(viewResult);
            Assert.AreEqual(string.Empty, viewResult.ViewName);
            Assert.IsFalse(viewResult.ViewData.ModelState.IsValid);
        }

    }
}
