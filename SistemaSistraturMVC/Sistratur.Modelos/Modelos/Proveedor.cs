using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public String Ruc { get; set; }
        public String RazonSocial { get; set; }
        public String Representante { get; set; }
        public String Direccion { get; set; }
        public int Celular { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }

        public int? CiudadId { get; set; }
        public virtual Ciudad Ciudad { get; set; }

        public virtual ICollection<DetalleArticulo> DetallesArticulos { get; set; }

    }
}
