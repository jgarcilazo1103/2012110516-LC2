﻿using _2012110516_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            HasRequired(e => e.Evaluacion)
                .WithMany(v => v.Ventas)
                .HasForeignKey(v => v.EvaluacionId);


        }
    }
}
