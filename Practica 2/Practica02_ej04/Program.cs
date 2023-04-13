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

            Calle calle1 = new Calle("s1", "Calle A", 140, 2, EnumOcupacion.Rojo);
            Calle calle2 = new Calle("s2", "Calle B", 150, 3, EnumOcupacion.Rojo);
            Calle calle3 = new Calle("s3", "Calle C", 120, 2, EnumOcupacion.Verde);
            Calle calle4 = new Calle("s4", "Calle D", 140, 2, EnumOcupacion.Rojo);
            Calle calle5 = new Calle("s5", "Calle E", 140, 2, EnumOcupacion.Rojo);

            Calle [] CEntrada = {calle1, calle2, calle3 };
            Calle[] CSalida = { calle4, calle5 };

            Cruce cruce1 = new Cruce("Cruce ABCDE", "C1",CEntrada, CSalida);
            
            string congestion = Convert.ToString(cruce1.Congestionado());

            Console.WriteLine("Cruce congestionado = " + congestion);

            Console.WriteLine("hehe");

            Console.ReadKey();
        }
    }
}
