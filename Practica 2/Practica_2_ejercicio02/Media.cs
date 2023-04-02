using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_ejercicio02
{
    internal class Media
    {
    
        public int media(int l, int[] a)
        {
            if (l == 0)
            {
                return a[0];
            }
            else
            {
                int total = media(l - 1, a);
                if (l < a.Length)
                {
                    return total + a[l];
                }
                else
                {
                    return total/a.Length;
                }
            }
        }
    }
}
