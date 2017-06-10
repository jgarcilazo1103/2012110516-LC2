using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2012110516_PER;

namespace _2012110516_PER.EntityTypeConfiguration
{
    public class EvaluacionConfiguration : EntityTypeConfiguration<EvaluacionConfiguration>
    {
        public EvaluacionConfiguration()
        {

            ToTable("Evaluacion");
            HasKey(p => p.idEvaluacion);

            HasRequired(c => c.cliente).WithMany(p => p.ListEvaluaciones);
        }
    }
}
