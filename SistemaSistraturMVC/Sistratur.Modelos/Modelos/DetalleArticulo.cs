using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Modelos.Modelos
{
    public class DetalleArticulo
    {

        public Int32 ArticuloId { get; set; }
        public Articulo Articulo { get; set; }

        public Int32 ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

    }
}
