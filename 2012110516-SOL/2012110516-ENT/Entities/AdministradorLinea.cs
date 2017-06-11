using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class AdministradorLinea
    {
        public int AdministradorLineaId { get; set; }
        public string NombreLinea { get; set; }

        public LineaTelefonica LineasTelefonica { get; set; }

        public AdministradorLinea()
        {
        }
    }
}
