using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Practica02_ej04.NivelesOcupacion;

namespace Practica02_ej04
{
    internal class Cruce
    {
        private string Nombre;
        private string Codigo;
        private Calle [] CallesEntrada;
        private Calle [] CallesSalida;

        public bool Congestionado()
        {
      
            int contEntrada = 0;
            int contSalida = 0;
            for (int i = 0; i < CallesEntrada.Length; i++)
            {
                NivelesOcupacion nEntrada = CallesEntrada[i].getOcupacion();
         

                if ( nEntrada == NivelOcupacion.Rojo)
                {
                    contEntrada++;
                }
            }
            for (int i = 0; i < CallesSalida.Length;)
            {
                if (CallesSalida[i].getOcupacion() == NivelOcupacion.Rojo)
                {
                    contSalida++;
                }
            }
            if (contEntrada >= CallesEntrada.Length/2 || contSalida >= CallesSalida.Length/2)
            {
                return true;
            }

            else { return false; }
        }
    }
}
