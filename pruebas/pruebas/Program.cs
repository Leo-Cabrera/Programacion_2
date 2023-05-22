using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    internal class Program
    {
        class ListaNodos
        {
            public Nodo[] listanodos { get; }
            public int count { get; private set; }
            private Nodo primero;
            private Nodo ultimo;

            public ListaNodos()
            {
                count= 0;
                primero = ultimo = null;
            }
            public bool IsEmpty()
            {
                return (count == 0);
            }
            public void Add(Object valor)
            {
               if(count == 0)
                {
                    primero = ultimo = new Nodo(valor);
                }
                else
                {
                    ultimo.Siguiente = new Nodo  (valor);
                    ultimo = new Nodo(valor);
                }
                count++;
          
            }
            public bool Contains (Object valor)
            {
                Nodo iterador = primero;
                for (int i = 1; i <= count; i++)
                {
                    if(iterador.Dato == valor)
                    {
                        return true;
                    }
                    
                }
                return false;

            }
            public bool Remove (object valor)
            {
                Nodo anterior = primero;    
                Nodo iterador=primero;
                while (iterador!= null)
                {
                    if (iterador.Dato.Equals(valor))
                    {
                        if(iterador == primero)
                        {
                            primero = iterador.Siguiente;
                        }
                        else if (iterador == ultimo)
                        {
                            ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = iterador.Siguiente;
                            
                        }
                        count--;
                        return true;
                    }
                    else
                    {
                        anterior = iterador;
                        iterador = iterador.Siguiente;
                    }
                    
                }
                return false;
            }
            public Object ElementAt(int indice)
            {
                Nodo iterador = primero;
                if (indice>=0 && indice <= count)
                {
                    for (int i = 1; i == indice; i++)
                    {
                        iterador = iterador.Siguiente;

                    }
                    return iterador;
                }
                else
                {
                    return null;
                }
               
               
            }
            public override string ToString()
            {
                string convertido="(";
                Nodo iterador = primero;
                for (int i = 1; i < count; i++)
                {
                    convertido = iterador.Dato+", ";
                    iterador = iterador.Siguiente;
                }
                convertido = iterador.Dato + ")";
                return convertido;
            }

        }
        class Nodo
        {
            
            public Nodo Siguiente { get; set; }
            public Object Dato { get; set; }
            public Nodo(Object dato)
            {
                this.Dato = dato;
                this.Siguiente = null;
            }
        }
        static void Main(string[] args)
        {
            /*Nodo n1 = new Nodo("awimawe");
            Nodo n2 = new Nodo("awimawe");
            Nodo n3 = new Nodo("uuuuuuuuuuuuuuuuu");
            n1.Siguiente = n2;
            n2.Siguiente = n3;*/
            ListaTest lt = new ListaTest();
            bool[] resTest = lt.HazTest();
            for(int i =0; i< resTest.Length; i++)
            {
                Console.WriteLine("Test #" + i + ":" + resTest[i]);
            }



        }
        class ListaTest
        {

            ListaNodos ln;

            public ListaTest() 
            { 
                ln = new ListaNodos();
            }

            public bool SonIguales(string s1, string s2)
            {
                return (s1 == s2) ? true : false;

            }

            public bool SonIguales(bool b1, bool b2){ // Sobrecarga
                return (b1 == b2);

            }

            public bool[] HazTest()
            {

                bool[] resultados = new bool[5]; // Se realizan 5 test
                resultados[0] = SonIguales (ln.ToString(), "()"); // Comprueba ToString()
                for (int i=0; i< 8; i++) ln.Add(i);

                resultados[1] = SonIguales(ln.ToString(), "(0, 1, 2, 3, 4, 5, 6, 7, )");

                ln.Remove(3);

                ln.Remove(5); 
                resultados[2] = SonIguales(ln.ToString(), "(0, 1, 2, 4, 6, 7, )"); 
                resultados[3] = SonIguales(ln.Contains(5), false);
                resultados[4] = SonIguales(ln.Contains(2), true);

                return resultados;

            }

        } // Fin de la clase
    }
}
