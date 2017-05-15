using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2012110516_ENT;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class EstadoEvaluacionConfiguration : EntityTypeConfiguration<EvaluacionConfiguration>
    {
        public EstadoEvaluacionConfiguration()
        {
            ToTable("Estado Evaluacion");
        }
    }
}
