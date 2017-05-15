using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Plan
    {
        public int idPlan { set; get; }
        public TipoPlan tipoPlan { set; get; }
        public int idTipoPlan { set; get; }
        public String restricciones { set; get; }
    }
}
