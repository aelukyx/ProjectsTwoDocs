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
    public class UsuarioRolesConfiguration: EntityTypeConfiguration<UsuarioRoles>
    {
        public UsuarioRolesConfiguration()
        {

            ToTable("UsuarioRoles", "dbo");

            HasKey(i => new { i.PerfilUsuarioId, i.RolId });
            Property(i => i.PerfilUsuarioId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(i => i.RolId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(o => o.perfilUsuario)
                .WithMany(o => o.UsuarioRoles)
                .HasForeignKey(o => o.PerfilUsuarioId);

            HasRequired(o => o.Rol)
                .WithMany(o => o.UsuarioRoles)
                .HasForeignKey(o => o.RolId);

        }
    }
}
