﻿using System;
using System.Collections.Generic;
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

            //Relations Configuration

            HasMany(c => c.ServiciosClinico)
                .WithRequired(c => c.Veterinario)
                 .HasForeignKey(c => c.VeterinarioId);
        }
    }
}
