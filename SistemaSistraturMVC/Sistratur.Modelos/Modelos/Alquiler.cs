using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class Alquiler
    {
        public int Id { get; set; }

        public int FechaServicioDia { get; set; }
        public int FechaServicioMes { get; set; }
        public int FechaServicioAnio { get; set; }

        public String HoraServicio { get; set; }

        public String LugarReferencia { get; set; }

        public int NroDias { get; set; }

        public Decimal Montodia { get; set; }

        public Decimal MontoTotal { get; set; }

        public String Observaciones { get; set; }

        public String FechaInicio { get; set; }
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
