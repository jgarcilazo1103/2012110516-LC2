﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012110516_ENT.Entities
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public string nomProvincia { get; set; }


        public ICollection<Distrito> Distritos { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

        public Provincia()
        {
            Distritos = new Collection<Distrito>();
        }
    }
}
