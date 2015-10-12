using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

using Sistratur.Modelos.Modelos;

namespace Sistratur.BaseDeDatos.Mapeado
{
    public class ConductorConfiguration : EntityTypeConfiguration<Conductor>
    {

        public ConductorConfiguration()
        {
            ToTable("Conductor", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Dni)
                .HasMaxLength(8)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Dni") { IsUnique = true }));
            Property(o => o.NombreCompleto)
                .HasMaxLength(250)
                .IsRequired();
            Property(o => o.Celular)
                .IsRequired();
            Property(o => o.Telefono)
                .IsOptional();
            Property(o => o.CategoriaLicencia)
                .HasMaxLength(7)
                .IsRequired();
            Property(o => o.NroLicencia)
                .HasMaxLength(9)
                .IsRequired();
            Property(o => o.FechEmisLicenia);
            Property(o => o.FechCaducLicenia);
            Property(o => o.FechContratacion);
            Property(o => o.FechFinContrato);
            Property(o => o.Activo);
            Property(o => o.Direccion)
                .HasMaxLength(200)
                .IsRequired();
            Property(o => o.Email)
                .HasMaxLength(50)
                .IsOptional();
            Property(o => o.FechaRegistro)
                .IsRequired();
            Property(o => o.Observaciones)
                .HasMaxLength(200)
                .IsOptional();

        }
    }
}
