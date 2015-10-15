using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Modelos.Modelos;

using System.Data.Entity.ModelConfiguration;

//Para Atributos Unicos
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Sistratur.BaseDeDatos.Mapeado
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {

        public ClienteConfiguration()
        {
            ToTable("Cliente", "dbo");
            HasKey(o => o.Id);

        }
    }
}
