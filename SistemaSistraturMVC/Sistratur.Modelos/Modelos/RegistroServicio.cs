using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class RegistroServicio
    {
        public int Id { get; set; }
        public int RegIdAlquiler { get; set; }
        public String RegNombreConductor { get; set; }
        public int RegNroDias { get; set; }
        public int RegMes { get; set; }
        public int RegAnio { get; set; }


    }
}
