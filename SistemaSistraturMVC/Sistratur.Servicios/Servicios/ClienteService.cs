using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.BaseDeDatos.Modelado;
using Sistratur.Interfaces.Servicios;
using Sistratur.Modelos.Modelos;

namespace Sistratur.Servicios.Servicios
{
    public class ClienteService : IClienteService
    {

        private readonly SistraturEntities entities;


        public ClienteService(SistraturEntities entities)
        {
            this.entities = entities;
        }

        public IList<Cliente> All()
        {
            return entities.Clientes.ToList();
        }

        public void Insert(Cliente cliente)
        {
            entities.Clientes.Add(cliente);
            entities.SaveChanges();
        }
    }
}
