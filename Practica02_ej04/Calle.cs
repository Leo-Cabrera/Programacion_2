using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_ej04
{
    internal class Calle
    {
        private int Longitud { get; set; }
        private int NumCarriles { get; set; }
        private string Nombre { get; set; }
        private string Codigo { get; set; }
        NivelesOcupacion ocupacion;

        public Calle (string codigo, string nombre, int longitud, int numcarr,NivelesOcupacion ocupacion)
        {
            Codigo= codigo;
            Nombre= nombre;
            Longitud = longitud;
            NumCarriles = numcarr;
            this.ocupacion = ocupacion;

        }
    }
