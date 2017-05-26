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
   public class MedioPagoConfiguration : EntityTypeConfiguration<MedioPago>
    {
        
        public MedioPagoConfiguration()
        {
            ToTable("MediosPago");

            HasKey(c => c.MedioPagoId);

            Property(a => a.MedioPagoId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relations Configuration

            HasMany(c => c.Ventas)
                .WithRequired(c => c.MedioPago)
                 .HasForeignKey(c => c.MedioPagoId);
        }
    }
}
