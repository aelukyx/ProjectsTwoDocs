using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistratur.Models.Models
{
    public class Cliente
    {
        public Cliente()
        {
            this.Alquiler = new List<Alquiler>();
        }

        public int Id { get; set; }
        public bool TipoDoc { get; set; }
        public String NroDocumento { get; set; }
        public String NombresRazonSocial { get; set; }
        public String AppPaterno { get; set; }
        public String AppMaterno { get; set; }
        public int Celular { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String Comentarios { get; set; }

        public virtual ICollection<Alquiler> Alquiler { get; set; }

    }
}
