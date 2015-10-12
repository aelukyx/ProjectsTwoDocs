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
    public class AlquilerService : IAlquilerService
    {

        private readonly SistraturEntities entities;

        public AlquilerService(SistraturEntities entities)
        {
            this.entities = entities;
        }

        public IList<Alquiler> All()
        {
            return entities.Alquileres.ToList();
        }

        public void Insert(Alquiler alquiler)
        {
            entities.Alquileres.Add(alquiler);
            entities.SaveChanges();
        }

        public List<Cliente> TraerClientes()
        {
            return entities.Clientes.ToList();
        }

        public List<Conductor> TraerConductores()
        {
            return entities.Conductores.ToList();
        }

        public List<PerfilUsuario> TraerPerfilUsuarios()
        {
            return entities.PerfilesUsuarios.ToList();
        }

        public Alquiler TraerPorId(int id)
        {
            return entities.Alquileres.First(x => x.Id == id);
        }

        public List<Vehiculo> TraerVehiculos()
        {
            return entities.Vehiculos.ToList();
        }
    }
}
