using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class Vehiculo
    {
        public Vehiculo()
        {
            this.Alquiler = new List<Alquiler>();
        }

        public int Id { get; set; }
        public String Placa { get; set; }
        public Decimal Kilometraje { get; set; }
        public int AnioModelo  { get; set; }
        public int AnioFabricación { get; set; }
        public int Ejes { get; set; }
        public int Ruedas { get; set; }
        public String Categoria { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String FormulaRodante { get; set; }
        public String Potencia { get; set; }
        public String Carroceria { get; set; }
        public Double Alto { get; set; }
        public Double Ancho { get; set; }
        public Double Longitud { get; set; }
        public int NroAsientos { get; set; }
        public int NroPasajeros { get; set; }
        public Double Cilindros { get; set; }
        public Double Cilindrada { get; set; }
        public Double CargaUtil { get; set; }
        public Double PesoBruto { get; set; }
        public Double PesoNeto { get; set; }

        public int? CombustibleId { get; set; }
        public virtual Combustible Combustible { get; set; }

        public int? EstadoVehiculoId { get; set; }
        public virtual EstadoVehiculo EstadoVehiculo { get; set; }

        public int? MarcaVehiculoId { get; set; }
        public virtual MarcaVehiculo MarcaVehiculo { get; set; }

        public int? ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }

        public int? ColorId { get; set; }
        public virtual Color Color { get; set; }

        public int? TipoId { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }

        public virtual ICollection<Alquiler> Alquiler { get; set; }

        public virtual ICollection<DetalleArticuloToVehiculo> DetallesArticulosToVehiculo { get; set; }



    }
}
