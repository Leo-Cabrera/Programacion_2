﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int [3,6];

            for (int i = 0; i < matriz.Length;i++)
            {
                for (int j = 0; j< matriz.Length; j++)
                {
                    Console.WriteLine("Dame el elemento("+Convert.ToString(i)+"," + Convert.ToString(j)+")");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            
            
          

            for (int k = 0; k < matriz.GetLength(1); k++) 
            {
                for (int i = matriz.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < matriz.GetLength(0) - 1; j++) 
                    {
                       
                        if (matriz[j, k] != 0 && matriz[j+1,k]==0)
                        {

                            int aux = matriz[j, k];
                            matriz[j, k] = matriz[j + 1, k];
                            matriz[j + 1, k] = aux;
                        }


                    }

                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    
                    Console.Write(Convert.ToString(matriz[i, j])+" ");



                }


            }
            Console.ReadKey();
        }
    }
}
