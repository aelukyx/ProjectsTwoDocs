using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Sistratur.Modelos.Modelos;

namespace Sistratur.BaseDeDatos.Mapeado
{
    public class DetalleArticuloConfiguration : EntityTypeConfiguration<DetalleArticulo>
    {
        public DetalleArticuloConfiguration()
        {

            ToTable("DetalleArticulo", "dbo");

            HasKey(i => new { i.ArticuloId, i.ProveedorId });
            Property(i => i.ArticuloId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(i => i.ProveedorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(o => o.Articulo)
                .WithMany(o => o.DetallesArticulos)
                .HasForeignKey(o => o.ArticuloId);

            HasRequired(o => o.Proveedor)
                .WithMany(o => o.DetallesArticulos)
                .HasForeignKey(o => o.ProveedorId);

        }
    }
}
