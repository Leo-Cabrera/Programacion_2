using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_1_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime la cantidad de paquetes que quieres: ");
            int cant = Convert.ToInt32(Console.ReadLine());
            double precio = 0;
            if (0 < cant && cant < 200 )
            {
                precio = 4.5;

            }
            else if (200 < cant && cant < 500)
            {
                precio = 3.75;

            }
            else if (cant > 500)
            {
                precio = 3.25;

            }
            Console.WriteLine("El precio es: " + cant * precio);
            Console.ReadKey();
        }
    }
}
