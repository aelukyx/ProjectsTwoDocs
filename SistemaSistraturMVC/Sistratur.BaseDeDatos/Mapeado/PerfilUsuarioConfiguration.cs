using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Modelos.Modelos;


namespace Sistratur.BaseDeDatos.Mapeado
{
    public class PerfilUsuarioConfiguration : EntityTypeConfiguration<PerfilUsuario>
    {
        public PerfilUsuarioConfiguration()
        {

            ToTable("PerfilUsuario", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Dni)
                .HasMaxLength(8)
                .IsRequired();
            Property(o => o.Nombres)
                .HasMaxLength(100)
                .IsRequired();
            Property(o => o.AppPaterno)
                .HasMaxLength(100)
                .IsOptional();
            Property(o => o.AppMaterno)
                .HasMaxLength(100)
                .IsOptional();
            Property(o => o.Username)
                .HasMaxLength(50)
                .IsRequired();
            Property(o => o.Password)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
