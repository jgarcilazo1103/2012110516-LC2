using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2012110516_ENT;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class UbiGeoConfiguration : EntityTypeConfiguration<UbiGeoConfiguration>
    {
        public UbiGeoConfiguration()
        {

            ToTable("Ubigeo");
            HasKey(p => p.idUbigeo);

            HasRequired(c => c.provincia).WithRequiredDependent(p => p.ubigeo);
            HasRequired(c => c.departamento).WithRequiredDependent(p => p.ubigeo);

        }
    }
}
