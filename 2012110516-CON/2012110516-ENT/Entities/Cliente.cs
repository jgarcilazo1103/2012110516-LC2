using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Cliente
    {
        public int idCliente { set; get; }
        public String Dni { set; get; }
        public String nombres { set; get; }
        public String apellidos { set; get; }
        public String correo { set; get; }

        public List<Evaluacion> ListEvaluaciones { set; get; }
        public List<Venta> ListVentas { set; get; }
    }
}
