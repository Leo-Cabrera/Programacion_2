using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_1_Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el largo del primer vector: ");
            int largo1 = Convert.ToInt32(Console.ReadLine());
            int[] vect1;
            vect1 = new int[largo1];

            for (int i = 0; i < largo1; i++)
            {
                Console.WriteLine("Dame el elemento " + i);
                vect1[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Dame el largo del segundo vector: ");
            int largo2 = Convert.ToInt32(Console.ReadLine());
            int[] vect2;
            vect2 = new int[largo2];

            for (int i = 0; i < largo2; i++)
            {
                Console.WriteLine("Dame el elemento " + i);
                vect2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int j = 0;
            int k = 0;
            int[] vectf;
            vectf = new int[largo1 + largo2];
            for(int i = 0; i < largo1+largo2 && j<largo1 && k<largo2; i++)
            {
                if (vect1[j] < vect2[k])
                {
                    vectf[i] = vect1[j];
                    j++;
                }
                else
                {
                    vectf[i] = vect2[k];
                    k++;
                }
            }

            if (j == largo1)
            {
                for (int i = k; i < largo2; i++)
                {
                    vectf[i + j] = vect2[i];
                }
            }
            else
            {
                for (int i = j; i < largo1; i++)
                {
                    vectf[i + k] = vect1[i];
                }
            }

            for (int i = 0; i < largo1 + largo2; i++)
            {
                Console.Write(vectf[i]);
               
            }
        }
    }
}
