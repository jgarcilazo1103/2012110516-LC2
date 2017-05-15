using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class TipoEvaluacion
    {

        private char renovar = '0';
        public char Renovar { get => renovar; set => renovar = value; }

        private char portabilidad = '1';
        public char Portabilidad { get => portabilidad; set => portabilidad = value; }
      
        private char lineaNueva = '2';
        public char LineaNueva { get => lineaNueva; set => lineaNueva = value; }

    }
}
