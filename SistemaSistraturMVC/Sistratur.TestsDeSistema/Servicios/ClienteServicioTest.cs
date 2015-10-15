using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.WebApp.Controllers;
using Sistratur.Interfaces.Servicios;
using Sistratur.Modelos.Modelos;
using Sistratur.Servicios.Servicios;
using Sistratur.BaseDeDatos.Modelado;
using Sistratur.BaseDeDatos.Mapeado;

using Sistratur.TestsDeSistema.Modelos;

using Moq;
using NUnit.Framework;
using System.Data.Entity;
using System.Web.Mvc;


namespace Sistratur.TestsDeSistema.Servicios
{
    [TestFixture]
    public class ClienteServicioTest
    {
        private Mock<SistraturEntities> entitiesMock;

        [SetUp]
        public void SetUp()
        {
            //  Arrange 
            var db = ClienteFakeDB();
            var mockDbset = new Mock<IDbSet<Cliente>>();
            mockDbset.Setup(x => x.Provider).Returns(db.Provider);
            mockDbset.Setup(x => x.Expression).Returns(db.Expression);
            mockDbset.Setup(x => x.ElementType).Returns(db.ElementType);
            mockDbset.Setup(x => x.GetEnumerator()).Returns(db.GetEnumerator);
            entitiesMock = new Mock<SistraturEntities>();
            entitiesMock.Setup(x => x.Clientes).Returns(mockDbset.Object);
        }

        [Test]
        public void _00_RetornarListaClientes()
        {
            var service = new ClienteService(entitiesMock.Object);

            var result = service.All();

            Assert.IsInstanceOf(typeof(IList<Cliente>), result);
            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void _01_RetornarClientePorId()
        {

            var service = new ClienteService(entitiesMock.Object);

            var result = service.TraerPorId(1);

            Assert.AreEqual("Juan Jose", result.NombresRazonSocial);
            Assert.AreEqual("Guillermo", result.AppPaterno);
        }


        [Test]
        public void _02_RegistrarNuevoCliente()
        {

            var service = new ClienteService(entitiesMock.Object);

            service.Insert(new Cliente { Id = 4, NroDocumento = "98545214", NombresRazonSocial = "Juan Jose", AppPaterno = "Guillermo" });
        }

        private IQueryable<Cliente> ClienteFakeDB()
        {
            return new List<Cliente>
            {
                new Cliente { Id = 1, NroDocumento = "71621467", NombresRazonSocial = "Juan Jose", AppPaterno = "Guillermo"},
                new Cliente { Id = 2, NroDocumento = "15268745", NombresRazonSocial = "Pedro Martín", AppPaterno = "Zavaleta"}

            }.AsQueryable();
        }
    }
}
