using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Modelos.Modelos
{
    public class Articulo
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public String Codigo { get; set; }
        public int Stock { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int? CategoriaId { get; set; }
        public virtual CategoriaArticulo CategoriaArticulo { get; set; }

        public int? MarcaArticuloId { get; set; }
        public virtual MarcaArticulo MarcaArticulo { get; set; }

        public virtual ICollection<DetalleArticulo> DetallesArticulos { get; set; }

        public virtual ICollection<DetalleArticuloToVehiculo> DetallesArticulosToVehiculo { get; set; }

    }
}
