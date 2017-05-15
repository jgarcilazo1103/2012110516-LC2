using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class AdminEquipo
    {
        
            public int idAdminEquipo { set; get; }
            public String DNI { set; get; }
            public String nombres { set; get; }
            public String apellidos { set; get; }
            public String correo { set; get; }

            public EquipoCelular EquipoCelular { set; get; }
        
    }
}
