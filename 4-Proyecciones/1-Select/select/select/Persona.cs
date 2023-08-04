using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select
{
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
