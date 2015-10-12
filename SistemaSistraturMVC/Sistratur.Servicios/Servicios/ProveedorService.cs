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
    public class ProveedorService : IProveedorService
    {

        private readonly SistraturEntities entities;

        public ProveedorService(SistraturEntities entities)
        {
            this.entities = entities;
        }

        public IList<Proveedor> All()
        {
            return entities.Proveedores.ToList();
        }

        public void Insert(Proveedor proveedor)
        {
            entities.Proveedores.Add(proveedor);
            entities.SaveChanges();
        }

        public List<Ciudad> TraerCiudades()
        {
            return entities.Ciudades.ToList();
        }

        public Ciudad TraerCiudadPorId(int id)
        {
            return entities.Ciudades.First(x => x.Id == id);
        }
    }

}
