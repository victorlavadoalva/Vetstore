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
   public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            ToTable("Servicios");

            HasKey(c => c.ServicioId);

            Property(a => a.ServicioId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Map<ServicioClinico>(m => m.Requires("Discriminator").HasValue("ServicioClinico"));
            Map<ServicioEstetico>(m => m.Requires("Discriminator").HasValue("ServicioEstetico"));
            Map<ServicioHospedaje>(m => m.Requires("Discriminator").HasValue("ServicioHospedaje"));
            Map<ServicioRecreativo>(m => m.Requires("Discriminator").HasValue("ServicioRecreativo"));
        }
    }
}
