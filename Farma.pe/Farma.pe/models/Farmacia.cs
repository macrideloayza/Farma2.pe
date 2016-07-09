﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma.pe.models
{
    public class Farmacia
    {
       
        public int ID_FAR { get; set; }
        public int ID_DIS { get; set; }
        public string NOM_FAR { get; set; }
        public string DIR_FAR { get; set; }
        public Nullable<decimal> CORX_FAR { get; set; }
        public Nullable<decimal> CORDY_FAR { get; set; }
        public string HORARIO_FAR { get; set; }
        public string rutaImagen { get; set; }
        public string rutaFlecha { get; set; }

    }
}