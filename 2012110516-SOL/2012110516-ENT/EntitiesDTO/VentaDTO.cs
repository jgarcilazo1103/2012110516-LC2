﻿using _2012110516_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.EntitiesDTO
{
    public class VentaDTO
    {
        public int VentaId { get; set; }
        public int Precio { get; set; }
        public TipoPago TipoPago { get; set; }
    }
}
