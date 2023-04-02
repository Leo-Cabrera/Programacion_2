using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_1_Ejercicio_3
{
    internal class Program
    {
        public int Factorial(int num)
        {
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Calcular el factorial de: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El factorial es: " + Convert.ToString(p.Factorial(numero))); 
        }

    }
}
