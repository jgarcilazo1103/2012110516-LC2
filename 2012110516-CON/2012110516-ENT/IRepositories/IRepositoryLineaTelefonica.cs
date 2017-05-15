using _2012110516_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.IRepository
{
    public interface IRepositoryLineaTelefonica
    {
        IEnumerable<LineaTelefonica> getLineaporAdministrador(AdminLinea AdminLinea);
        IEnumerable<LineaTelefonica> getLineaporEvaluacion(Evaluacion Evaluacion);
    }
}
