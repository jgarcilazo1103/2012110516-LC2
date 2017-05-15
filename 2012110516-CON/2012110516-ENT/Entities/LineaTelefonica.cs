using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class LineaTelefonica
    {
        public int idLineaTelefonica { set; get; }
        public TipoLinea tipoLinea { set; get; }
        public String numeroCelular { set; get; }

        public AdminLinea adminLinea { set; get; }
        public int idAdminLinea { set; get; }
    }
}
