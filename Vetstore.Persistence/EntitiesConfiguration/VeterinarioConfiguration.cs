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
    public class VeterinarioConfiguration : EntityTypeConfiguration<Veterinario>
    {
        public VeterinarioConfiguration()
        {
            ToTable("Veterinarios");

            HasKey(c => c.VeterinarioId);

            Property(a => a.VeterinarioId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relations Configuration

            HasMany(c => c.ServiciosClinico)
                .WithRequired(c => c.Veterinario)
                 .HasForeignKey(c => c.VeterinarioId);
        }
    }
}
