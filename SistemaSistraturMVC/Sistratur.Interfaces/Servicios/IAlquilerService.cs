using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Modelos.Modelos;

namespace Sistratur.Interfaces.Servicios
{
    public interface IAlquilerService
    {

        IList<Alquiler> All();
        Alquiler TraerPorId(int id);
        List<Vehiculo> TraerVehiculos();
        List<Conductor> TraerConductores();
        List<Cliente> TraerClientes();
        List<PerfilUsuario> TraerPerfilUsuarios();
        
        void Insert(Alquiler alquiler);

    }
}
