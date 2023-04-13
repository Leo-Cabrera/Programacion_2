using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Practica02_ej04.NivelesOcupacion;
using static Practica02_ej04.Calle;

namespace Practica02_ej04
{
    internal class Cruce
    {
        private string Nombre;
        private string Codigo;
        private Calle [] CallesEntrada;
        private Calle [] CallesSalida;

        public Cruce (string nombre, string codigo, Calle[] callesEntrada, Calle[] callesSalida)
        {
            Nombre = nombre;
            Codigo = codigo;
            CallesEntrada = callesEntrada;
            CallesSalida = callesSalida;
        }

        public bool Congestionado()
        {
      
            int contEntrada = 0;
            int contSalida = 0;
            for (int i = 0; i < CallesEntrada.Length; i++)
            {
         
                if (CallesEntrada[i].GetOcupacion() == "Rojo")
                {
                    contEntrada++;
                }
            }
            for (int i = 0; i < CallesSalida.Length;)
            {
                if (CallesSalida[i].GetOcupacion() == "Rojo")
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
