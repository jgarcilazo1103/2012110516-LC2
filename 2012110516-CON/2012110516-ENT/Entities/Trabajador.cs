using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Trabajador
    {
        public int idTrabajador { set; get; }
        public TipoTrabajador tipotrabajador { set; get; }
        public String nombres { set; get; }
        public String apellidos { set; get; }
        public List<Evaluacion> ListEvaluaciones { set; get; }
    }
}
