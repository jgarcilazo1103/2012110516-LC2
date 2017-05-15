using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2012110516_ENT;
namespace _2012110516_PER.EntityTypeConfiguration
{
    public class AdminLineaConfiguration : EntityTypeConfiguration<AdminLineaConfiguration>
    {
        public AdminLineaConfiguration()
        {

            ToTable("AdministradorLinea");
            HasKey(p => p.idAdminLinea);


        }
    }
}
