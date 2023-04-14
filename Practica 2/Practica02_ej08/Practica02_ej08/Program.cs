using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,]matriz = new int[,] { { 2, 0, 0, 2, 0, 0 }, { 4, 0, 0, 2, 0, 0, }, { 4, 16, 4, 8, 2, 2 } };

            /*for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    Console.WriteLine("Dame el elemento(" + Convert.ToString(i) + "," + Convert.ToString(j) + ")");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }*/



            for (int k = 0; k < matriz.GetLength(0); k++)
            {
                for (int i = matriz.GetLength(1) - 1; i > 0; i--)
                {
                    for (int j = 0; j < matriz.GetLength(1) - 1; j++)
                    {
                        if (j+1 < matriz.GetLength(1))
                        {
                            if (matriz[k,j] == matriz[k, j+1] && matriz[k, j] != 0)
                            {
                                matriz[k, j+1] = matriz[k, j] + matriz[k, j+1];
                                if (j > 0)
                                {
                                    matriz[k,j] = matriz[k, j-1];
                                    matriz[k, j-1] = 0;
                                }
                                else if (j == 0)
                                {
                                    matriz[k, j] = 0;
                                }

                            }
                        }



                    }

                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    Console.Write(Convert.ToString(matriz[i, j]) + " ");



                }


            }
            Console.ReadKey();
        }
    
    }
}
