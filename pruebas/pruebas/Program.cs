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
            public bool IsEmpty()
            {
                bool vacia = false;
                foreach ( Nodo i in listanodos)
                {
                    if(i == null)
                    {
                        vacia = true;
                    }
                
                }
                return vacia;
            }
            public void Add(Object valor)
            {
               
          
            }
            public bool Contain (Object valor)
            {
                bool contiene = false;
                foreach (Nodo i in listanodos)
                {
                    if (i.Dato == valor)
                    {
                        contiene = true;
                    }

                }
                return contiene;

            }
            public void Remove (object valor)
            {
                foreach (Nodo i in listanodos)
                {
                    if (i.Dato == valor)
                    {
                        i.Dato = null;
                    }

                }
                foreach (Nodo i in listanodos)
                {
                    if (i.Dato == null)
                    {
                        Nodo aux = i;
                        Nodo nodo1 = i;
                        Nodo nodo2 = i.Next;
                    }

                }
            }
            public Object ElementAt(int indice)
            {
                if (indice>=0 && indice < listanodos.Length)
                {
                    return listanodos[indice];
                }
                else
                {
                    return null;
                }
            }
            public override string ToString()
            {
              for(i)
            }
        }
        class Nodo
        {
            
            public Nodo Sig { get; set; }
            public Object Dato { get; set; }
            public Nodo(Object dato)
            {
                this.Dato = dato;
                this.Sig = null;
            }
        }
        static void Main(string[] args)
        {
            Nodo n1 = new Nodo("awimawe");
            Nodo n2 = new Nodo("awimawe");
            Nodo n3 = new Nodo("uuuuuuuuuuuuuuuuu");
            n1.Sig = n2;
            n2.Sig = n3;



        }
    }
}
