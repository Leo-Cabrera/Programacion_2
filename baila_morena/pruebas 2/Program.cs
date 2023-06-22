using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace pruebas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           string [] BailaMorena_Texto= File.ReadAllLines("documento random.txt");


           StreamWriter CompositorChimba = new StreamWriter("Intento de copioa del documento random");



           for (int i = 0; i < BailaMorena_Texto.Length; i++)
           {
               CompositorChimba.WriteLine( "Z -"+BailaMorena_Texto[i]+"- nitt");

           }
           CompositorChimba.Close();

           string[] BailaMorena_UwU = File.ReadAllLines("Intento de copioa del documento random");

           for (int i = 0; i < BailaMorena_Texto.Length; i++)
           {

               Console.WriteLine(BailaMorena_Texto[i] + "                            " + BailaMorena_UwU[i]);

           }
           Console.WriteLine("Fin jeje");

           string[] BailaMorena_Texto = File.ReadAllLines("documento random.txt");
           Console.WriteLine(BailaMorena_Texto[7]);
           Console.WriteLine("a");*/


            public void Seleccion(int[] v)
            {
                int minimo;
                int aux;

                for (int i = 0; i < v.Length - 1; i++)
                {
                    minimo = i;
                    for (int j = i + 1; j < v.Length; j++)
                    {
                        if (v[j] < v[minimo])
                        {
                            minimo = j;
                        }
                    }
                    aux = v[i];
                    v[i] = v[minimo];
                    v[minimo] = aux;
                }
            }
            int minimo = 0;
            while (minimo = 0) { }

            Console.ReadLine();
        }
    }
}
