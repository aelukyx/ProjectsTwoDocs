using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Modelos.Modelos;

namespace Sistratur.BaseDeDatos.Mapeado
{
    public class VehiculoConfiguration: EntityTypeConfiguration<Vehiculo>
    {
        public VehiculoConfiguration()
        {

            ToTable("Vehiculo", "dbo");
            HasKey(o => o.Id);

            Property(o => o.Kilometraje)
                .HasPrecision(9,2);

            Property(o => o.Alto)
                .HasPrecision(9, 2);

            Property(o => o.Ancho)
                .HasPrecision(9, 2);

            Property(o => o.Longitud)
                .HasPrecision(9, 2);

            Property(o => o.Cilindrada)
                .HasPrecision(9, 2);

            Property(o => o.Cilindrada)
                .HasPrecision(9, 2);

            Property(o => o.CargaUtil)
                .HasPrecision(9, 2);

            Property(o => o.PesoBruto)
                .HasPrecision(9, 2);

            Property(o => o.PesoNeto)
                .HasPrecision(9, 2);

            HasRequired(o => o.Combustible)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.CombustibleId);

            HasRequired(o => o.EstadoVehiculo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.EstadoVehiculoId);

            HasRequired(o => o.MarcaVehiculo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.MarcaVehiculoId);

            HasRequired(o => o.Modelo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.ModeloId);

            HasRequired(o => o.TipoVehiculo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.TipoId);

            HasRequired(o => o.Color)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.ColorId);


        }
    }
}
