using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistratur.Modelos.Modelos
{
    public class Vehiculo
    {
        public Vehiculo()
        {
            this.Alquiler = new List<Alquiler>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        [Index("NroPlacaUnique", IsUnique = true)]
        public String Placa { get; set; }

        [Display(Name = "Año Modelo")]
        public int AnioModelo  { get; set; }

        [Display(Name = "Año Fabricacion")]
        public int AnioFabricacion { get; set; }
        public int Ejes { get; set; }
        public int Ruedas { get; set; }

        [Display(Name = "Nro. Asientos")]
        public int NroAsientos { get; set; }

        [Display(Name = "Nro. Pasajeros")]
        public int NroPasajeros { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }

        [Required]
        [MaxLength(20)]
        public String Categoria { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Fórmula Rodante")]
        public String FormulaRodante { get; set; }

        [Required]
        [MaxLength(20)]
        public String Potencia { get; set; }

        [Required]
        [MaxLength(50)]
        public String Carroceria { get; set; }

        public Decimal Kilometraje { get; set; }
        public Decimal Alto { get; set; }
        public Decimal Ancho { get; set; }
        public Decimal Longitud { get; set; }
        public Decimal Cilindros { get; set; }
        public Decimal Cilindrada { get; set; }

        [Display(Name = "Carga Util")]
        public Decimal CargaUtil { get; set; }

        [Display(Name = "Carga Bruto")]
        public Decimal PesoBruto { get; set; }

        [Display(Name = "Peso Neto")]
        public Decimal PesoNeto { get; set; }

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
