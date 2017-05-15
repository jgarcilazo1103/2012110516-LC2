using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2012110516_ENT;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class VentaConfiguration : EntityTypeConfiguration<VentaConfiguration>
    {
       public VentaConfiguration()
        {

            ToTable("Venta");
            HasKey(p => p.idVenta);

            HasRequired(c => c.evaluacion).WithRequiredDependent(p => p.venta);
            HasRequired(c => c.contrato).WithMany(p => p.ventas);

        }
    }
}
