using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistratur.Models.Models
{
    public class Conductor
    {

        public Conductor()
        {
            this.Alquiler = new List<Alquiler>();
        }

        public int Id { get; set; }
        public String Dni { get; set; }
        public String NombreCompleto { get; set; }
        public String Direccion { get; set; }
        public int Celular { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public String CategoriaLicencia { get; set; }
        public String NroLicencia { get; set; }
        public DateTime FechEmisLicenia { get; set; }
        public DateTime FechCaducLicenia { get; set; }
        public DateTime FechContratacion { get; set; }
        public DateTime FechFinContrato { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public String Observaciones { get; set; }

        public virtual ICollection<Alquiler> Alquiler { get; set; }

    }
}
