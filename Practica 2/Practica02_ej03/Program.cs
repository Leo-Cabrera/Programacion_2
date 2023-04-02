using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej03
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[,] matriz = { { 1, 2 },{ 1, 2 } };
            bool a = EnteroEnMatriz(matriz, 0, 0, 2);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        public static bool EnteroEnMatriz(int [,] matriz, int i, int j, int num)
        {
            Console.WriteLine(i + " " + j);
            if (matriz[i, j] == num) return true;

            else if (i == matriz.GetLength(1) - 1 && j < matriz.GetLength(0)-1) //cambio de linea
            {
                i = 0;
                j++;
                return EnteroEnMatriz(matriz, i, j, num);
            }
            else if (i == matriz.GetLength(1) - 1 && j == matriz.GetLength(0) - 1) //fin matriz
            {
                return false;
            }

            else
            {
                i++;
                return EnteroEnMatriz(matriz, i, j, num);
            }
            
        }
    }
}
