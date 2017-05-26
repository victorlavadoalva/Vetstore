﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;

namespace Vetstore.Persistence.EntitiesConfiguration
{
    public class EspecieConfiguration : EntityTypeConfiguration<Especie>
    {
        public EspecieConfiguration()
        {
            ToTable("Especies");

            HasKey(c => c.EspecieId);

            Property(a => a.EspecieId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relations Configuration

            HasMany(c => c.Razas)
                .WithRequired(c => c.Especie)
                 .HasForeignKey(c => c.EspecieId);


        }
    }
}
