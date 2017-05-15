using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012110516_ENT;
namespace _2012110516_PER.EntityTypeConfiguration
{
    public class AdminEquipoConfiguration : EntityTypeConfiguration<AdminEquipoConfiguration>
    {
        
            public AdminEquipoConfiguration()
            {

                ToTable("AdministradorEquipo");
                HasKey(p => p.idAdminEquipo);


            }
    }
}
