using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Provincia
    {
        public int idProvincia { set; get; }
        public String nombreProvincia { set; get; }
        public Departamento departamento { set; get; }
        public int idDepartamento { set; get; }

        public List<Distrito> ListDistritos { set; get; }
        public UbiGeo ubigeo { set; get; }
    }
}
