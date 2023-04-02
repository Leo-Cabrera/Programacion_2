using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_1_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime la cadena: ");
            string cadena = Console.ReadLine();
            bool Capicua = true;
            for (int i = 0; i < cadena.Length / 2; i++)
            {
                if (cadena[i] != cadena[(cadena.Length) - i-1])
                {  
                    Capicua = false;
                    break;
                }
                
            }
            if (Capicua)
            {
                Console.WriteLine("Es capicua.");
            }
            else
            {
                Console.WriteLine("No es capicua.");
            }

        }
    }
}
