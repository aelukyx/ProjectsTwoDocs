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
    public class VehiculoService : IVehiculoService
    {

        private readonly SistraturEntities entities;

        public VehiculoService(SistraturEntities entities)
        {
            this.entities = entities;
        }

        public IList<Vehiculo> All()
        {
            return entities.Vehiculos.ToList();
        }

        public void Insert(Vehiculo vehiculo)
        {
            entities.Vehiculos.Add(vehiculo);
            entities.SaveChanges();
        }

        public List<MarcaVehiculo> TraerMarcasVehiculo()
        {
            return entities.MarcaVehiculos.ToList();
        }

        public List<Color> TraerColores()
        {
            return entities.Colores.ToList();
        }

        public List<Combustible> TraerCombustibles()
        {
            return entities.Combustibles.ToList();
        }

        public List<EstadoVehiculo> TraerEstadosVehiculos()
        {
            return entities.EstadosVehiculos.ToList();
        }

        public List<Modelo> TraerModelos()
        {
            return entities.Modelos.ToList();
        }

        public Vehiculo TraerPorId(int id)
        {
            return entities.Vehiculos.First(x => x.Id == id);
        }

        public List<TipoVehiculo> TraerTiposVehiculos()
        {
            return entities.TiposVehiculos.ToList();
        }
    }
}
