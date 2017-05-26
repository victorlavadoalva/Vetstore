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
   public class UbigeoConfiguration : EntityTypeConfiguration<Ubigeo>
    {
        public UbigeoConfiguration()
        {
            ToTable("Ubigeos");

            HasKey(c => c.UbigeoId);

            Property(a => a.UbigeoId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relations Configuration
            HasRequired(c => c.Departamento)
                .WithRequiredPrincipal(c => c.Ubigeo);

            HasRequired(c => c.Distrito)
                .WithRequiredPrincipal(c => c.Ubigeo);

            HasRequired(c => c.Provincia)
                .WithRequiredPrincipal(c => c.Ubigeo);
           

            HasMany(c => c.Direcciones)
                .WithRequired(c => c.Ubigeo)
                 .HasForeignKey(c => c.UbigeoId);


        }
    }
}
