using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity.ModelConfiguration;

using Sistratur.Modelos.Modelos;

namespace Sistratur.BaseDeDatos.Mapeado
{
    public class AlquilerConfiguration: EntityTypeConfiguration<Alquiler>
    {
        public AlquilerConfiguration()
        {

            ToTable("Alquiler", "dbo");
            HasKey(o => o.Id);

            Property(o => o.Montodia)
                .HasPrecision(9, 2);

            Property(o => o.MontoTotal)
                .HasPrecision(9, 2);

            HasRequired(o => o.Conductor)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.ConductorId);

            HasRequired(o => o.Vehiculo)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.VehiculoId);

            HasOptional(o => o.PerfilUsuario)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.PerfilUsuarioId);

            HasRequired(o => o.Cliente)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.ClienteId);
        }
    }
}
