using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class TipoLinea
    {
        private char prepago = '1';
        public char Prepago { get => prepago; set => prepago = value; }
       
        private char postPago = '0';
        public char PostPago { get => postPago; set => postPago = value; }

    }
}
