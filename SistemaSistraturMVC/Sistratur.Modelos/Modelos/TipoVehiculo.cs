using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Modelos.Modelos
{
    public class TipoVehiculo
    {

        public TipoVehiculo()
        {
            this.Vehiculos = new List<Vehiculo>();
        }

        public int Id { get; set; }
        public String Descripcion { get; set; }
        public String Observaciones { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
