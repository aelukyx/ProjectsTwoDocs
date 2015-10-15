using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistratur.Modelos.Modelos
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [MaxLength(11)]
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "El campo Ruc debe ser de 11 dígitos.")]
        [Display(Name = "Ruc")]
        [Index("RucProvUnique", IsUnique = true)]
        public String Ruc { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [MaxLength(200)]
        public String RazonSocial { get; set; }

        [MaxLength(200)]
        public String Representante { get; set; }

        [Required]
        [MaxLength(200)]
        public String Direccion { get; set; }

        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "El campo celular debe ser de 9 dígitos.")]
        public String Celular { get; set; }

        [MaxLength(9)]
        [MinLength(6)]
        [Display(Name = "Teléfono")]
        public String Telefono { get; set; }

        public String Email { get; set; }

        public int? CiudadId { get; set; }
        public virtual Ciudad Ciudad { get; set; }

        public virtual ICollection<DetalleArticulo> DetallesArticulos { get; set; }

    }
}
