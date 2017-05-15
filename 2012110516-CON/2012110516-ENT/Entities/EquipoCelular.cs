using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class EquipoCelular
    {
        public int idEquipoCelular { set; get; }
        public String modeloCelular { set; get; }
        public String nroSerieCelular { set; get; }
        public AdminEquipo adminEquipo { set; get; }
        public int idAdministradorEquipo { set; get; }
    }
}
