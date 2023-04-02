using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej04
{
    internal class NivelesOcupacion
    {
        private string ocupacion;
        public NivelesOcupacion(string niveocup)
        {
            ocupacion = niveocup;

        }
        public void SetOcupacion( string color ) { ocupacion = color; }
        public string GetOcupacion() { return ocupacion;  }

       
    }
}
