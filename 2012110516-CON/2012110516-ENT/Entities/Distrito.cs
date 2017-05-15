using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Distrito
    {
        public int idDistrito { set; get; }
        public String nombreDistrito { set; get; }
        public Provincia provincia { set; get; }
        public int idProvincia { set; get; }
        public UbiGeo ubigeo { set; get; }
    }
}
