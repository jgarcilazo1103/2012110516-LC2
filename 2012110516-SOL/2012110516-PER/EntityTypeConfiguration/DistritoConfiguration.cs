using _2012110516_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class DistritoConfiguration : EntityTypeConfiguration<Distrito>
    {
        public DistritoConfiguration()
        {
            HasRequired(c => c.Provincia)
                .WithMany(c => c.Distritos)
                .HasForeignKey(c => c.ProvinciaId);
        }
    }
}
