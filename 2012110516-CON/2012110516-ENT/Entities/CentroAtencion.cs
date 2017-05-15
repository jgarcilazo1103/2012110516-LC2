using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class CentroAtencion
    {
        public int idCentroAtencion { set; get; }
        public String nombreCentro { set; get; }
        public Direccion direccion { set; get; }
        public int idDireccion { set; get; }

    }
}
