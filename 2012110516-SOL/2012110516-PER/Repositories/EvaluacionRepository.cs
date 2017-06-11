using _2012110516_ENT.Entities;
using _2012110516_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_PER.Repositories
{
    public class EvaluacionRepository : Repository<Evaluacion>, IEvaluacion
    {
        public EvaluacionRepository(_2012110516DBContext context) : base(context)
        {

        }
    }
}
