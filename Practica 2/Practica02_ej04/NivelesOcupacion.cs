using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej04
{
    internal class NivelesOcupacion
    {
        public enum NivelOcupacion { Verde, Amarillo, Rojo };

        private NivelOcupacion ocupacion { get; }
        public NivelesOcupacion(string niveocup)
        {
            if (niveocup == "Verde")
            {
                ocupacion = NivelOcupacion.Verde;
            }
            else if (niveocup == "Amarillo")
            {
                ocupacion = NivelOcupacion.Amarillo;
            }
            else if (niveocup == "Rojo")
            {
                ocupacion = NivelOcupacion.Rojo;
            }
            else
            {
                Console.WriteLine("No es un color valido");
            }   
        }
        



    }
}
