using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practica02_ej04.NivelesOcupacion;

namespace Practica02_ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*NivelesOcupacion ocupacion1 = new NivelesOcupacion("Rojo");
            NivelesOcupacion a = ocupacion1.GetOcupacion();                POSIBLEMENTE MAL*/
            Calle calle1 = new Calle("s5", "Calle E", 140, 2, NivelOcupacion.Rojo) ;
        }
    }
}
