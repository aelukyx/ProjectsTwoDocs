using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Modelos.Modelos
{
    public class UsuarioRoles
    {
        public Int32 PerfilUsuarioId { get; set; }
        public PerfilUsuario perfilUsuario { get; set; }

        public Int32 RolId { get; set; }
        public Rol Rol { get; set; }

    }
}
