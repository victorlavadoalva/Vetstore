using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;

namespace Vetstore.Persistence.EntitiesConfiguration
{
    public class RazaConfiguration : EntityTypeConfiguration<Raza>
    {
        public RazaConfiguration()
        {
            ToTable("Razas");

            HasKey(c => c.RazaId);

            Property(a => a.RazaId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
