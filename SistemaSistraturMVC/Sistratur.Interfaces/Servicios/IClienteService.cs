using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Modelos.Modelos;

namespace Sistratur.Interfaces.Servicios
{
    public interface IClienteService
    {
        IList<Cliente> All();
        void Insert(Cliente cliente);
    }
}
