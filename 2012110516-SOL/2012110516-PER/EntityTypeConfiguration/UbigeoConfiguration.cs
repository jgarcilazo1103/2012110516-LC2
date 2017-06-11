using _2012110516_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class UbigeoConfiguration : EntityTypeConfiguration<Ubigeo>
    {
        public UbigeoConfiguration()
        {
            HasRequired(d => d.Distrito)
                 .WithMany(u => u.Ubigeos)
                 .HasForeignKey(d => d.DistritoId);

        }
    }
}
