﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whereObjetos
{
    [DebuggerDisplay("{Nombre}")]
    public class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public bool Soltero { get; set; }   

        public DateTime Ingreso { get; set; }

        public List<string> Telefonos = new List<string>();

        public int IdEmpresa { get; set; }
    }
}
