using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Modelos.Modelos;

namespace Sistratur.Interfaces.Servicios
{
    public interface IVehiculoService
    {
        IList<Vehiculo> All();
        Vehiculo TraerPorId(int id);
        List<Combustible> TraerCombustibles();
        List<EstadoVehiculo> TraerEstadosVehiculos();
        List<TipoVehiculo> TraerTiposVehiculos();
        List<Modelo> TraerModelos();
        List<Color> TraerColores();
        List<MarcaVehiculo> TraerMarcasVehiculo();

        void Insert(Vehiculo vehiculo);

    }
}
