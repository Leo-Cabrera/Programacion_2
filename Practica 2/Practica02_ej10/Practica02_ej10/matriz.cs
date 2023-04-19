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
        //private int[,] IntM = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

        

        public static int[,] Arriba (int [,] M_entrada)
        {
            for (int k = 0; k < M_entrada.GetLength(1); k++)
            {
                for (int i = M_entrada.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(0) - 1; j++)
                    {

                        if (M_entrada[j, k] == 0 && M_entrada[j + 1, k] != 0)
                        {

                            int aux = M_entrada[j, k];
                            M_entrada[j, k] = M_entrada[j + 1, k];
                            M_entrada[j + 1, k] = aux;
                        }
                    }
                }
            }
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

                                M_entrada[j, k] = M_entrada[j, k] + M_entrada[j + 1, k];

                                if (j + 2 < M_entrada.GetLength(0))
                                {
                                    M_entrada[j + 1, k] = M_entrada[j + 2, k];
                                    M_entrada[j + 2, k] = 0;
                                }
                                if (j + 2 >= M_entrada.GetLength(0))
                                {
                                    M_entrada[j + 1, k] = 0;
                                }

                            }
                            if (M_entrada[j, k] == 0 && M_entrada[j + 1, k] != 0)
                            {

                                int aux = M_entrada[j, k];
                                M_entrada[j, k] = M_entrada[j + 1, k];
                                M_entrada[j + 1, k] = aux;
                            }
                        }
                    }
                }
            }

            return M_entrada;
        }

        public static int[,] Abajo(int[,] M_entrada)
        {
            for (int k = 0; k < M_entrada.GetLength(1); k++)
            {
                for (int i = M_entrada.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(0) - 1; j++)
                    {

                        if (M_entrada[j, k] != 0 && M_entrada[j + 1, k] == 0)
                        {

                            int aux = M_entrada[j, k];
                            M_entrada[j, k] = M_entrada[j + 1, k];
                            M_entrada[j + 1, k] = aux;
                        }
                    }
                }
            }
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

        public static int[,] Izquierda(int[,] M_entrada)
        {
            for (int k = 0; k < M_entrada.GetLength(0); k++)
            {
                for (int i = M_entrada.GetLength(1) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(1); j++)
                    {
                        if (j + 1 < M_entrada.GetLength(1))
                        {
                            if (M_entrada[k, j] == 0 && M_entrada[k, j + 1] != 0)
                            {

                                int aux = M_entrada[k, j];
                                M_entrada[k, j] = M_entrada[k, j + 1];
                                M_entrada[k, j + 1] = aux;
                            }
                        }
                    }

                }
            }

            for (int k = 0; k < M_entrada.GetLength(0); k++)
            {
                for (int i = M_entrada.GetLength(1) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(1) - 1; j++)
                    {
                        if (j + 1 < M_entrada.GetLength(1))
                        {

                            if (M_entrada[k, j] == M_entrada[k, j + 1] && M_entrada[k, j] != 0)
                            {
                                M_entrada[k, j] = M_entrada[k, j] + M_entrada[k, j + 1];


                                if (j < M_entrada.GetLength(1) + 1)
                                {
                                    M_entrada[k, j + 1] = M_entrada[k, j + 2];
                                    M_entrada[k, j + 2] = 0;
                                }
                                if (j == M_entrada.GetLength(1))
                                {
                                    M_entrada[k, j + 1] = 0;
                                }

                            }
                            if (M_entrada[k, j] == 0 && M_entrada[k, j + 1] != 0)
                            {

                                int aux = M_entrada[k, j];
                                M_entrada[k, j] = M_entrada[k, j + 1];
                                M_entrada[k, j + 1] = aux;
                            }
                        }
                    }

                }
            }
            return M_entrada;
        }


        public static int[,] Derecha(int[,] M_entrada)
        {
            for (int k = 0; k < M_entrada.GetLength(0); k++)
            {
                for (int i = M_entrada.GetLength(1) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(1); j++)
                    {
                        if (j + 1 < M_entrada.GetLength(1))
                        {
                            if (M_entrada[k, j] != 0 && M_entrada[k, j + 1] == 0)
                            {

                                int aux = M_entrada[k, j];
                                M_entrada[k, j] = M_entrada[k, j + 1];
                                M_entrada[k, j + 1] = aux;
                            }
                        }
                    }
                }
            }


            for (int k = 0; k < M_entrada.GetLength(0); k++)
            {
                for (int i = M_entrada.GetLength(1) - 1; i > 0; i--)
                {
                    for (int j = 0; j < M_entrada.GetLength(1) - 1; j++)
                    {
                        if (j + 1 < M_entrada.GetLength(1))
                        {
                            if (M_entrada[k, j] == M_entrada[k, j + 1] && M_entrada[k, j] != 0)
                            {
                                M_entrada[k, j + 1] = M_entrada[k, j] + M_entrada[k, j + 1];

                                if (j > 0)
                                {   
                                    M_entrada[k, j] = M_entrada[k, j - 1];
                                    M_entrada[k, j - 1] = 0;
                                }
                                if (j == 0)
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

        public static int[,] Nrandom(int[,] M_entrada)
        {   
            int[] pos_i = new int[M_entrada.GetLength(0) * M_entrada.GetLength(1)];
            int[] pos_j = new int[M_entrada.GetLength(0) * M_entrada.GetLength(1)];

            int cont_i = 0;
            int cont_j = 0;
            int cont = 0;
            bool win = false;
            for (int i = 0; i <M_entrada.GetLength(0); i++)
            {
                for (int j = 0; j <M_entrada.GetLength(1); j++)
                {
                    if (M_entrada[i, j] == 0)
                    {
                        pos_i[cont_i] = i;
                        pos_j[cont_j] = j;
                        cont_i++;
                        cont_j++;
                        cont++;
                    }
                    else if (M_entrada[i, j] == 2048)
                    {
                        win = true;
                    }
                }
            }
            if (win)
            {
                int[,] winm = new int[,] { { 1, 1 }, { 1, 1 } };
                return winm;
            }
            else if(cont!=0)
            {
                Random random = new Random();
                int random_pos = random.Next(cont_i);
                M_entrada[pos_i[random_pos], pos_j[random_pos]] = 2;
                return M_entrada;
            }
            else {
                int[,] lose = new int[,] { {0, 0}, { 0, 0 } };
                return lose ;
            }
           

        }

       
    }
}
