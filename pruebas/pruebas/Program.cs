using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] M_entrada = new int[,] { { 2, 0, 0, 2, 0, 0 }, { 4, 0, 0, 2, 0, 0, }, { 4, 16, 4, 8, 2, 2 } };

            /*for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    Console.WriteLine("Dame el elemento(" + Convert.ToString(i) + "," + Convert.ToString(j) + ")");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }*/



            for (int k = 0; k < M_entrada.GetLength(1); k++)
            {
                for (int i = M_entrada.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(0) - 1; j++)
                    {

                        if (j + 1 < M_entrada.GetLength(0))
                        {
                            if (M_entrada[j, k] == M_entrada[j + 1, k] && M_entrada[j, k] != 0)
                            {


                                M_entrada[j, k] = M_entrada[j, k] + M_entrada[j + 1, k];

                                if (j < M_entrada.GetLength(0) - 2)
                                {
                                    M_entrada[j + 1, k] = M_entrada[j + 2, k];
                                    M_entrada[j + 2, k] = 0;
                                }
                                if (j == M_entrada.GetLength(0) - 2)
                                {
                                    M_entrada[j + 1, k] = 0;
                                }
                            }
                        }

                    }
                }
            }
            for (int i = 0; i < M_entrada.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M_entrada.GetLength(1); j++)
                {

                    Console.Write(Convert.ToString(M_entrada[i, j]) + " ");



                }


            }
            Console.ReadKey();
        }
    }
}
