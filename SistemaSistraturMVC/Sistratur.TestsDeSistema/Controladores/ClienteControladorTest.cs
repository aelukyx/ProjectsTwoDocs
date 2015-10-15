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

namespace Sistratur.TestsDeSistema.Controladores
{
    [TestFixture]
    public class ClienteControllerTest
    {

        [Test]
        public void _00_VistaIndexListaClienteOk()
        {
            //Arrange
            var mock = new Mock<IClienteService>();
            mock.Setup(x => x.All()).Returns(new List<Cliente>());
            var controller = new ClienteController(mock.Object);

            // Act

            var view = controller.Index();

            //Afirmar - Assert
            mock.Verify(x => x.All(), Times.Once);
            AssertViewsWithModel(view, "Index");
            Assert.IsInstanceOf(typeof(List<Cliente>), view.Model);
        }

        [Test]
        public void _01_VistaCreateRegistrarClienteOk()
        {
            var controller = new ClienteController(null);

            var view = controller.Create() as ViewResult;

            AssertViewWithoutModel(view, "Create");

        }

        [Test]
        public void _02_ClienteGuardadoCorrectamenteOk()
        {
            var mock = new Mock<IClienteService>();
            var controller = new ClienteController(mock.Object);

            var redirect = controller.Create(new Cliente { NombresRazonSocial = "Mi Primer Cliente" }) as RedirectToRouteResult;

            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }

        [Test]
        public void _03_VistaEditEditarClienteOk()
        {
            var mock = new Mock<IClienteService>();
            mock.Setup(x => x.TraerPorId(1)).Returns(new Cliente());

            var controller = new ClienteController(mock.Object);

            var view = controller.Edit(1) as ViewResult;

            AssertViewsWithModel(view, "Edit");
            mock.Verify(x => x.TraerPorId(1), Times.Exactly(1));

        }
        [Test]
        public void _04_EditEditarClienteGuardoCorrectamenteOk()
        {
            //arrange
            var mock = new Mock<IClienteService>();
            var controller = new ClienteController(mock.Object);

            var redirect = controller.Edit(new Cliente { NombresRazonSocial = "Cliente Modificado" }) as RedirectToRouteResult;

            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }

        [Test]
        public void _05_VistaDetailsDetallesClienteOk()
        {
            // Arrange
            var mock = new Mock<IClienteService>();
            mock.Setup(x => x.TraerPorId(1)).Returns(new Cliente { });
            var controller = new ClienteController(mock.Object);

            // Act

            var view = controller.Details(1) as ViewResult;

            //Afirmar - Assert
            AssertViewsWithModel(view, "Details");
            Assert.IsInstanceOf(typeof(Cliente), view.Model);
        }


        [Test]
        public void _05_VistaDetailsRedireciionarAIndezCuandoIdIsZeroOk()
        {
            // Arrange

            var controller = new ClienteController(null);

            // Act

            var redirect = controller.Details(0) as RedirectToRouteResult;

            //Afirmar - Assert
            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }



        //[Test]
        //public void TestClienteValicacionFallaReturnViewCreate()
        //{
        //    var mock = new Mock<IClienteService>();
        //    var controller = new ClienteController(mock.Object);

        //    var view = controller.Create(new Cliente()) as ViewResult;

        //    AssertViewsWithModel(view, "Create");
        //    Assert.IsInstanceOf(typeof(Cliente), view.Model);

        //}



        //[Test]
        //public void TestEditCuandoValidacionFallaRetronaVistaEdit()
        //{
        //    var controller = new ClienteController(null);

        //    var view = controller.Edit(new Cliente()) as ViewResult;

        //    AssertViewsWithModel(view, "Edit");

        //}

        private void AssertViewsWithModel(ViewResult view, string viewName)
        {
            Assert.IsNotNull(view, "Vista no puede ser nulo");
            Assert.AreEqual(viewName, view.ViewName);
            Assert.IsNotNull(view.Model);
        }

        private void AssertViewWithoutModel(ViewResult view, string viewName)
        {
            Assert.IsNotNull(view);
            Assert.AreEqual(viewName, view.ViewName);
            Assert.IsNull(view.Model);
        }
    }
}
