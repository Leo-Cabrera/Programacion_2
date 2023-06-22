using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaTest listaTest = new ListaTest();
            bool[] resTestLista = listaTest.Haztest();
            Console.WriteLine("Test Lista:");
            for (int i = 0; i < resTestLista.Length; i++)
            {
                Console.WriteLine("Test #{0}: {1}", i, resTestLista[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Test Cola:");
            ColaTest colaTest = new ColaTest();
            bool[] resTestCola = colaTest.Haztest();
            for (int i = 0; i < resTestCola.Length; i++)
            {
                Console.WriteLine("Test #{0}: {1}", i, resTestCola[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Test Pila:");
            PilaTest pilaTest = new PilaTest();
            bool[] resTestPila = pilaTest.Haztest();
            for (int i = 0; i < resTestPila.Length; i++)
            {
                Console.WriteLine("Test #{0}: {1}", i, resTestPila[i]);
            }

            Console.ReadKey();
        }

        class Nodo
        {
            public Object dato;
            public Nodo sig;

            public Nodo(Object dato)
            {
                this.dato = dato;
                sig = null;
            }
        }

        class NodoAnt
        {
            public Object dato;
            public NodoAnt ant;
            

            public NodoAnt(Object dato)
            {
                this.dato = dato;
                ant = null;
               
            }
        }

        class ListaNodos
        {
            public int count { get; private set; }
            private Nodo primero;
            private Nodo ultimo;

            public ListaNodos()
            {
                count = 0;
                primero = ultimo = null;

            }
            public bool IsEmpty()
            {
                return count == 0;
            }
            public void Add(Object valor)
            {
                Nodo nuevo = new Nodo(valor);
                if (count == 0)
                {
                    primero = ultimo = nuevo;

                }
                else
                {
                    ultimo.sig = nuevo;
                    ultimo = nuevo;
                }

                count++;
            }
            public bool contains(Object valor)
            {
                Nodo iterador = primero;

                while (iterador != null)
                {
                    if (iterador.dato.Equals(valor)) { return true; }

                    iterador = iterador.sig;

                }
                return false;
            }
            public bool Remove(Object valor)
            {
                Nodo anterior = primero;
                Nodo iterador = primero;




                while (iterador != null)
                {
                    if (iterador.dato.Equals(valor)) // por que no puedo poner "iterador.dato == valor"?
                    {
                        if (iterador == primero)
                        {
                            primero = iterador.sig;
                            primero.sig = null;
                        }
                        else if (iterador == ultimo)
                        {
                            ultimo = anterior;
                            ultimo.sig = null;
                        }
                        else
                        {
                            anterior.sig = iterador.sig;
                            iterador.sig = null;
                        }

                        count--;
                        return true;
                    }
                    else
                    {
                        anterior = iterador;
                        iterador = iterador.sig;
                    }


                }
                return false;

            }
            public Object ElementAt(int indice)
            {
                object valor = null;
                Nodo nodo_actual = primero;
                for (int i = 0; i <= indice; i++)
                {

                    valor = nodo_actual.dato;
                    nodo_actual = nodo_actual.sig;
                }
                return valor;
            }

            public override string ToString()
            {
                Nodo iterador = primero;
                string result = "(";
                while (iterador != null)
                {
                    result += iterador.dato + ",";

                    iterador = iterador.sig;

                }
                return result + ")";
            }
        }

        class ColaNodos
        {
            public int count { get; private set; }
            private Nodo primero;
            private Nodo ultimo;


            public ColaNodos()
            {
                count = 0;
                primero = ultimo = null;
            }
            public bool IsEmpty()
            {
                return count == 0;
            }
            public void EnQueue(object valor)
            {
                Nodo nuevo = new Nodo(valor);
                if (count == 0)
                {
                    primero = ultimo = nuevo;

                }
                else
                {
                    ultimo.sig = nuevo;
                    ultimo = nuevo;
                }
                count++;
            }

            public Object DeQueue()
            {

                if (count != 0)
                {
                    Nodo quitar = primero;
                    primero = primero.sig;
                    return quitar;
                }
                count--;
                return null;
            }
            public override string ToString()
            {
                Nodo iterador = primero;
                string result = "(";
                while (iterador != null)
                {
                    result += iterador.dato + ",";

                    iterador = iterador.sig;

                }
                return result + ")";
            }
        }

        class PilaNodos
        {
            private NodoAnt ultimo;
            private NodoAnt primero;
            

            public int count { get; private set; }
            public PilaNodos()
            {
                count = 0;
                ultimo = null;
            }
            public bool IsEmpty()
            {
                return count == 0;
            }

            public void Push(Object valor)
            {
                NodoAnt nuevo = new NodoAnt(valor);
                if (count == 0)
                {
                    ultimo = primero = nuevo;
                }

                else
                {
                    NodoAnt aux = ultimo;
                    ultimo = nuevo;
                    ultimo.ant = aux;
                    

                }

                count++;
                
            }

            public Object Read()
            {
                if (count != 0)
                {
                    return ultimo.dato;
                }
                return null;
            }

            public Object Pop()
            {
                Object dato = null;
                NodoAnt aux = null;

                if (count != 0)
                {
                    dato = ultimo.dato;
                    aux = ultimo;
                    ultimo = ultimo.ant;
                    aux.ant = null;


                    count--;
                }
                return dato;
            }

            public override string ToString()
            {
                NodoAnt iterador = ultimo;
                string result = "(";
                while (iterador != null)
                {
                    result += iterador.dato + ",";

                    iterador = iterador.ant;

                }
                return result + ")";
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
                return (s1 == s2) ? true : false; // que significa "? true:false" ?
            }

            public bool SonIguales(bool b1, bool b2)
            {
                return b1 == b2;
            }
            public bool SonIguales(object v1, object v2)
            {
                return v1.Equals(v2);
            }
            public bool[] Haztest()
            {
                bool[] resultados = new bool[6];
                resultados[0] = SonIguales(ln.ToString(), "()");
                for (int i = 0; i < 8; i++)
                {
                    ln.Add(i);
                }
                resultados[1] = SonIguales(ln.ToString(), "(0,1,2,3,4,5,6,7,)");
                ln.Remove(3);
                ln.Remove(5);
                resultados[2] = SonIguales(ln.ToString(), "(0,1,2,4,6,7,)");
                resultados[3] = SonIguales(ln.contains(5), false);
                resultados[4] = SonIguales(ln.contains(2), true);
                resultados[5] = SonIguales(ln.ElementAt(1), 1);
                resultados[5] = SonIguales(ln.ElementAt(4), 6);

                return resultados;
            }
        }

        class ColaTest
        {
            ColaNodos ln;
            public ColaTest()
            {
                ln = new ColaNodos();
            }

            public bool SonIguales(string s1, string s2)
            {
                return (s1 == s2) ? true : false; // que significa "? true:false" ?
            }


            public bool[] Haztest()
            {
                bool[] resultados = new bool[4];
                resultados[0] = SonIguales(ln.ToString(), "()");
                for (int i = 1; i < 11; i++)
                {
                    ln.EnQueue(i);
                }
                resultados[1] = SonIguales(ln.ToString(), "(1,2,3,4,5,6,7,8,9,10,)");
                ln.DeQueue();
                ln.DeQueue();
                resultados[2] = SonIguales(ln.ToString(), "(3,4,5,6,7,8,9,10,)");
                ln.EnQueue(11);
                ln.EnQueue(12);
                ln.EnQueue(13);
                resultados[3] = SonIguales(ln.ToString(), "(3,4,5,6,7,8,9,10,11,12,13,)");


                return resultados;
            }
        }

        class PilaTest
        {
            PilaNodos ln;
            public PilaTest()
            {
                ln = new PilaNodos();
            }

            public bool SonIguales(string s1, string s2)
            {
                return (s1 == s2) ? true : false; // que significa "? true:false" ?
            }


            public bool[] Haztest()
            {
                bool[] resultados = new bool[4];
                resultados[0] = SonIguales(ln.ToString(), "()");
                for (int i = 1; i < 11; i++)
                {
                    ln.Push(i);
                }
                resultados[1] = SonIguales(ln.ToString(), "(10,9,8,7,6,5,4,3,2,1,)");
                
                ln.Pop();
                ln.Pop();
                resultados[2] = SonIguales(ln.ToString(), "(8,7,6,5,4,3,2,1,)");
                
                ln.Push(11);
                ln.Push(12);
                ln.Push(13);
                resultados[3] = SonIguales(ln.ToString(), "(13,12,11,8,7,6,5,4,3,2,1,)");
                


                return resultados;
            }
        }
    }
}
