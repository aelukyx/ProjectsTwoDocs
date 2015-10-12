using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistratur.Modelos.Modelos
{
    public class Cliente
    {
        public Cliente()
        {
            this.Alquiler = new List<Alquiler>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "DNI/RUC")]
        public bool TipoDocumento { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [MaxLength(11)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Ingrese solo dígitos.")]
        [Display(Name = "Nro. Documento")]
        [Index("NroDocumentoUnique", IsUnique = true)]
        public string NroDocumento { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [MaxLength(200)]
        public String NombresRazonSocial { get; set; }

        [MaxLength(250)]
        public String AppPaterno { get; set; }

        [MaxLength(250)]
        public String AppMaterno { get; set; }

        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "El campo celular debe ser de 9 dígitos.")]
        public String Celular { get; set; }

        [MaxLength(9)]
        [MinLength(6)]
        [Display(Name = "Teléfono")]
        public String Telefono { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(125)]
        [Display(Name = "Correo Electrónico")]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }

        [StringLength(250)]
        [Display(Name = "Comentarios")]
        public String Comentarios { get; set; }

        public virtual ICollection<Alquiler> Alquiler { get; set; }

    }
}
