using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class TipoPago
    {
        private char credito = '0';
        public char Credito { get => credito; set => credito = value; }
        private char contado = '1';
        public char Contado { get => contado; set => contado = value; }
        
        
    }
}
