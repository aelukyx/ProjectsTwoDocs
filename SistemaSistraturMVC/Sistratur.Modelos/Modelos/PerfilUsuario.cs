using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Modelos.Modelos
{
    public class PerfilUsuario
    {
        public int Id { get; set; }
        public String Dni { get; set; }
        public String Nombres { get; set; }
        public String AppPaterno { get; set; }
        public String AppMaterno { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public virtual ICollection<Alquiler> Alquiler { get; set; }

        public virtual ICollection<UsuarioRoles> UsuarioRoles { get; set; }

    }
}
