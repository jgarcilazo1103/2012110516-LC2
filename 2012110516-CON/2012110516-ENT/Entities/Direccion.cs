using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Direccion
    {
        public int idDireccion { set; get; }
        public UbiGeo ubigeo { set; get; }
        public int idUbigeo { set; get; }
        public String descripcion { set; get; }
        public CentroAtencion centroatencion { set; get; }
        public String direccion { set; get; }
    }
}
