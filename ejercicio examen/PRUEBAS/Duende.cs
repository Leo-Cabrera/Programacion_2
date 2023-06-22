using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PRUEBAS.Campo_de_juego;
using static PRUEBAS.tesoro;

namespace PRUEBAS
{
    public enum color { rojo, verde, amarillo}; //enum
    class Duende
    {

        public Random random = new Random();
        public int x { get; protected set; } //modos de privacidad 
        public int y { get; protected set; } 
        public int nivel_energia { get; set; }
        public Campo_de_juego campo { get; protected set; }
        public color color { get; protected set; }

        public Duende(Campo_de_juego campo)
        {
            nivel_energia = 100;
            this.campo = campo;
            x = random.Next(0, campo.XMax + 1);
            y = random.Next(0, campo.YMax + 1);


            if (random.Next(0, 2)== 0) //enum
            {
                color = color.rojo;
            }
            else 
            {
                color = color.verde;
            }

        }

        public virtual string actuar()
        {
            return "";
        }
        public void moverse()
        {
            do
            {
                x += random.Next(-3, 4);
            }
            while (x < 0 || x > campo.XMax);

            do
            {
                y += random.Next(-3, 4);
            }
            while (y < 0 || y > campo.YMax);

            nivel_energia--;
        }
        
    }
    class Duende_revoltoso:Duende
    {
        public Duende_revoltoso(Campo_de_juego campo):base(campo) 
        {
            color = color.amarillo;
        }
        public override string actuar()
        {
            if(nivel_energia > 0)
            {
                switch (random.Next(0, 3)) 
                {
                    case 0:
                        return "ji,ji";
                        
                    case 1:
                        return "¡ahuuu!";
                        
                    case 2:
                        return "!Hey¡";
                        
                }
            }
            return "";
        }
    }
    class DuendeColeccionista: Duende //se puede dejar sin cosntructor de alguna manera?
    {
        public DuendeColeccionista(Campo_de_juego campo): base(campo) //por que me obliga a pasarle el campo?
        {                                                             // es porque debo pasarle exatamente los mismo parametros?


        }
        List<tesoro> Lista_tesoros = new List<tesoro>();
        
        public override string actuar()
        {
            string devolver  = "";
            if (Lista_tesoros.Count > 0)
            {
                int indice = random.Next(0, Lista_tesoros.Count);
                devolver = Convert.ToString(Lista_tesoros[indice]); // el casting solo se hace en caso de ser otro obejto
                                                                    // y no en los que existe el metodo convert?
                Lista_tesoros.RemoveAt(indice);
            }
            return devolver;
        }
        
    }
    class acciones
    {
        public void Golpear(List<Duende> lista_duendes, int n, int x, int y) // solo me deja ponerlo dentro pero según yo deberia ir fuera
        {
            for (int i = 0; i < lista_duendes.Count; i++)
            {
                if ((lista_duendes[i].x - x < 3 || lista_duendes[i].x - x < -3) && (lista_duendes[i].y - y < 3 || lista_duendes[i].y - y < -3))
                {
                    lista_duendes[i].nivel_energia -= n;
                    if (lista_duendes[i].nivel_energia < 0) { lista_duendes.RemoveAt(i); }
                }

            }
        }
        public string MensajeColeccionista(Duende[] arrayDuendes)
        {
            string resultado = "";

            for (int i = 0; i < arrayDuendes.Length; i++)
            {
                if (arrayDuendes[i] is DuendeColeccionista) { }
                resultado += arrayDuendes[i].ToString();
            }
            return resultado;
        }
        public Duende[] NDuendesMayorEnergía(int n, Duende[] array_duendes)
        {
            Duende[] resultado = array_duendes;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array_duendes.Length - i; j++)
                {
                    if (array_duendes[j].nivel_energia > array_duendes[j + 1].nivel_energia)
                    {
                        Duende aux = array_duendes[j];
                        array_duendes[j] = array_duendes[j + 1];
                        array_duendes[j + 1] = aux;
                    }
                }
                resultado[i] = array_duendes[n - i];
            }
            return resultado;
        }

        public List<Duende_revoltoso> DevolverRevoltosos(List<Duende> lista_duendes, List<Duende_revoltoso> lista_revoltosos, int i)
        {
            if (i == lista_duendes.Count) { return lista_revoltosos; }
            else if (lista_duendes[i] is Duende_revoltoso)
            {
                lista_revoltosos.Add((Duende_revoltoso)lista_duendes[i]);
                return DevolverRevoltosos(lista_duendes, lista_revoltosos, i++);
            }
            return DevolverRevoltosos(lista_duendes, lista_revoltosos, i++);
        }
    }
   
    

}
