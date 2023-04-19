using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[,] { { 8, 0, 4, 4, 0, 2 }, { 4, 16, 0, 2, 0, 0 }, { 0, 0, 0, 8, 2, 0 } }; //[3,6];
            int[] pos_i = new int[matriz.GetLength(0) * matriz.GetLength(1)];
            int[] pos_j = new int[matriz.GetLength(0) * matriz.GetLength(1)];

            int cont_i = 0;
            int cont_j = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        pos_i[cont_i] = i;
                        pos_j[cont_j] = j;
                        cont_i++;
                        cont_j++;
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }

            Random random = new Random();
            int random_pos = random.Next(cont_i);
            Console.WriteLine();
            Console.WriteLine(matriz[pos_i[random_pos], pos_j[random_pos]]+"("+pos_i[random_pos] + "," + pos_j[random_pos]+")"); 
                    //(número dentro de la matriz +(+ indice i +,+ indice j +))

            Console.ReadKey();

        }
    }
}
