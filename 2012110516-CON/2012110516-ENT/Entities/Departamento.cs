using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Departamento
    {
        public int idDepartamento { set; get; }
        public String nombreDepartamento { set; get; }
        public UbiGeo ubigeo { set; get; }
        public List<Distrito> ListaDistritos { set; get; }
        public List<Provincia> ListaProvincias { set; get; }
       
    }
}
