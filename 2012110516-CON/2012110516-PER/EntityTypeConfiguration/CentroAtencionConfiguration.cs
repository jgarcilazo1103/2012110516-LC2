using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2012110516_PER;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class CentroAtencionConfiguration : EntityTypeConfiguration<CentroAtencionConfiguration>
    {
        public CentroAtencionConfiguration()
        {

            ToTable("CentroAtencion");
            HasKey(p => p.idcentroAtencion);

            HasRequired(c => c.direccion).WithRequiredPrincipal(p => p.centroatencion);

        }
    }
}
