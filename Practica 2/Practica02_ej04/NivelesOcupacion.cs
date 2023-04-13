using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej04
{
    public class NivelesOcupacion
    {
        public enum EnumOcupacion { Verde, Amarillo, Rojo };
        private EnumOcupacion ocupacion { get; }
        public NivelesOcupacion(EnumOcupacion niveocup)
        {
            ocupacion = niveocup;
        }

        
        



    }
}
