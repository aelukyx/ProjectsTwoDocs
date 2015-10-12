using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Modelos.Modelos
{
    public class DetalleArticuloToVehiculo
    {
        public Int32 Id { get; set; }

        public Int32 ArticuloId { get; set; }
        public Articulo Articulo { get; set; }

        public Int32 VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public int Cantidad { get; set; }
        public DateTime FechaMontado { get; set; }
        public DateTime FechaRemovido { get; set; }
        public bool Descontinuado { get; set; }

    }
}
