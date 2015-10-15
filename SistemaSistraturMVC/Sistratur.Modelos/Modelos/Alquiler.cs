using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistratur.Modelos.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fecha de Registro")]
        public String FechaRegistro { get; set; }
        
        [StringLength(15)]
        [Display(Name = "Hora de Registro")]
        public String HoraRegistro { get; set; }

        [StringLength(150)]
        [Display(Name = "Lugar de Referencia")]
        public String LugarReferencia { get; set; }

        [Required]
        [Display(Name = "Número de Dias")]
        public int NroDias { get; set; }

        [Required]
        [Display(Name = "Monto/Día")]
        public Decimal Montodia { get; set; }

        [Required]
        [Display(Name = "Monto Total")]
        public Decimal MontoTotal { get; set; }

        [StringLength(250)]
        public String Observaciones { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Fecha Inicio")]
        public String FechaInicio { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Fecha Fin")]
        public String FechaFin { get; set; }

        public int? VehiculoId { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }

        public int? ConductorId { get; set; }
        public virtual Conductor Conductor { get; set; }

        public int? ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int? PerfilUsuarioId { get; set; }
        public virtual PerfilUsuario PerfilUsuario { get; set; }


    }
}
