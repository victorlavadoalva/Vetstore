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
    public class DireccionConfiguration: EntityTypeConfiguration<Direccion>
    {
        public DireccionConfiguration()
        {
            ToTable("Direcciones");

            HasKey(c => c.DireccionId);

            Property(a => a.DireccionId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Relations Configuration


        }
    }
}

