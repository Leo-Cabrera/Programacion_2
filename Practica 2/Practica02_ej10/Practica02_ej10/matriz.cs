using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej10
{
    internal class MatrizEnteros
    {
        private int[,] IntM;

        public MatrizEnteros(int[,] M_entrada){
            IntM = M_entrada;
        }

        public int[,] Arriba (int [,] M_entrada)
        {
            for (int k = 0; k < M_entrada.GetLength(1); k++)
            {
                for (int i = M_entrada.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(0) - 1; j++)
                    {

                        if (j+1 < M_entrada.GetLength(0))
                        {
                            if (M_entrada[j, k] == M_entrada[j + 1, k] && M_entrada[j, k] != 0)
                            {
                                
                               
                                    M_entrada[j, k] = M_entrada[j, k] + M_entrada[j + 1, k];
                                
                                if (j < M_entrada.GetLength(0) - 2)
                                {
                                    M_entrada[j+1, k] = M_entrada[j +2, k];
                                    M_entrada[j +2, k] = 0;
                                }
                                if (j == M_entrada.GetLength(0) - 2)
                                {
                                    M_entrada[j+1, k] = 0;
                                }
                            }
                        }
                    }
                }
            }
            return M_entrada;
        }

        public int[,] Abajo(int[,] M_entrada)
        {
            for (int k = 0; k < M_entrada.GetLength(1); k++)
            {
                for (int i = M_entrada.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(0) - 1; j++)
                    {
                        if (j < M_entrada.GetLength(0))
                        {
                            if (M_entrada[j, k] == M_entrada[j + 1, k] && M_entrada[j, k] != 0)
                            {
                                if (j + 1 < M_entrada.GetLength(0))
                                {
                                    M_entrada[j + 1, k] = M_entrada[j, k] + M_entrada[j + 1, k];
                                }
                                if (j > 0)
                                {
                                    M_entrada[j, k] = M_entrada[j - 1, k];
                                    M_entrada[j - 1, k] = 0;
                                }
                                if (j == 0)
                                {
                                    M_entrada[j, k] = 0;
                                }
                            }
                        }
                    }
                }
            }
            return M_entrada;
        }
        public int[,] Izquierda(int[,] M_entrada)
        {

            return M_entrada;
        }
        public int[,] Derecha(int[,] M_entrada)
        {
            for (int k = 0; k < M_entrada.GetLength(0); k++)
            {
                for (int i = M_entrada.GetLength(1) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(1) - 1; j++)
                    {
                        if (j+1 < M_entrada.GetLength(1))
                        {
                            if (M_entrada[k,j] == M_entrada[k, j+1] && M_entrada[k, j] != 0)
                            {
                                M_entrada[k, j+1] = M_entrada[k, j] + M_entrada[k, j+1];
                                if (j > 0)
                                {
                                    M_entrada[k,j] = M_entrada[k, j-1];
                                    M_entrada[k, j-1] = 0;
                                }
                                else if (j == 0)
                                {
                                    M_entrada[k, j] = 0;
                                }

                            }
                        }
                    }
                }
            }
            return M_entrada;
        }

    }
}
