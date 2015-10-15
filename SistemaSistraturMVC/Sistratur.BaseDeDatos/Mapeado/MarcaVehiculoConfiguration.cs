using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Modelos.Modelos;

namespace Sistratur.BaseDeDatos.Mapeado
{
    public class MarcaVehiculoConfiguration : EntityTypeConfiguration<MarcaVehiculo>
    {
        public MarcaVehiculoConfiguration()
        {

            ToTable("MarcaVehiculo", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Descripcion)
                .HasMaxLength(50)
                .IsRequired();
            Property(o => o.Observaciones)
                .HasMaxLength(200);

        }
    }
}