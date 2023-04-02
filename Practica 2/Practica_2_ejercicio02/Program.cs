using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, };
            Media m = new Media();
            Console.WriteLine(m.media(a.Length,a));
        }
    }
}
