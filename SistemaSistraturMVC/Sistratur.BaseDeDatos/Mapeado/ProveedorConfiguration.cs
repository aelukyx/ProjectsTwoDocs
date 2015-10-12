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
    public class ProveedorConfiguration : EntityTypeConfiguration<Proveedor>
    {
        public ProveedorConfiguration()
        {

            ToTable("Proveedor", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Ruc)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Ruc") { IsUnique = true }));
            Property(o => o.RazonSocial)
                .HasMaxLength(100)
                .IsRequired();
            Property(o => o.Celular)
                .IsRequired();
            Property(o => o.Telefono)
                .IsOptional();
            Property(o => o.Direccion)
                .HasMaxLength(200)
                .IsRequired();
            Property(o => o.Email)
                .HasMaxLength(50)
                .IsOptional();

            HasRequired(o => o.Ciudad)
                .WithMany(o => o.Proveedor)
                .HasForeignKey(o => o.CiudadId);


        }
    }
}
