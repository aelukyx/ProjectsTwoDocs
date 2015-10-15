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

        public Cliente TraerPorId(int id)
        {
            return entities.Clientes.First(x => x.Id == id);
        }

        public void Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
