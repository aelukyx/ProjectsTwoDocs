using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Modelos.Modelos;


namespace Sistratur.BaseDeDatos.Mapeado
{
    public class ArticuloConfiguration : EntityTypeConfiguration<Articulo>
    {
        public ArticuloConfiguration()
        {

            ToTable("Articulo", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Descripcion)
                .HasMaxLength(100)
                .IsRequired();
            Property(o => o.Codigo)
                .HasMaxLength(20)
                .IsOptional();
            Property(o => o.Stock)
                .IsRequired();
            Property(o => o.FechaRegistro);

            HasRequired(o => o.CategoriaArticulo)
                .WithMany(o => o.Articulo)
                .HasForeignKey(o => o.CategoriaId);

            HasRequired(o => o.MarcaArticulo)
                .WithMany(o => o.Articulo)
                .HasForeignKey(o => o.MarcaArticuloId);


        }
    }
}
