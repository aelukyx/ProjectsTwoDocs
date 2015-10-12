using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Modelos.Modelos;

namespace Sistratur.Interfaces.Servicios
{
    public interface IProveedorService
    {
        IList<Proveedor> All();
        Ciudad TraerCiudadPorId(int id);
        List<Ciudad> TraerCiudades();
        void Insert(Proveedor proveedor);
    }
}
