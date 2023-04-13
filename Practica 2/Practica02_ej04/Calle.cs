using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practica02_ej04.NivelesOcupacion;

namespace Practica02_ej04
{
    class Calle
    {
        private int Longitud { get; set; }
        private int NumCarriles { get; set; }
        private string Nombre { get; set; }
        private string Codigo { get; set; }
        public string OcupacionCalle;

        public Calle(string codigo, string nombre, int longitud, int numcarr, EnumOcupacion ocupacion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Longitud = longitud;
            NumCarriles = numcarr;
            OcupacionCalle = Convert.ToString(ocupacion);

        }

        public string GetOcupacion() { return OcupacionCalle; }
      
    }
}
