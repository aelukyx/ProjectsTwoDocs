using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Modelos.Modelos;


namespace Sistratur.BaseDeDatos.Mapeado
{
    public class CiudadConfiguration : EntityTypeConfiguration<Ciudad>
    {
        public CiudadConfiguration()
        {

            ToTable("Ciudad", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Descripcion)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
