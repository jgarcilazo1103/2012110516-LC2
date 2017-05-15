using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class EstadoEvaluacion 
    {
        private char aprobado = '0';

        public char Aprobado { get => aprobado; set => aprobado = value; }

        public char desaprobado = '1';

        public char Desaprobado { get => desaprobado; set => desaprobado = value; }
    }
}
