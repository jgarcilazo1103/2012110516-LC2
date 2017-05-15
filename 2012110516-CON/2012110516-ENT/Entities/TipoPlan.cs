using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class TipoPlan
    {

        private char planCaro = '1';
        public char PlanCaro { get => planCaro; set => planCaro = value; }
        private char planModico = '0';
        public char PlanModico { get => planModico; set => planModico = value; }
    }
}
