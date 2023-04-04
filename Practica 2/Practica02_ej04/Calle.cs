using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practica02_ej04.NivelesOcupacion;

namespace Practica02_ej04
{
    internal class Calle
    {
        private int Longitud { get; set; }
        private int NumCarriles { get; set; }
        private string Nombre { get; set; }
        private string Codigo { get; set; }
        private NivelOcupacion Ocupacion { get; set; }

        public Calle(string codigo, string nombre, int longitud, int numcarr, NivelOcupacion ocupacion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Longitud = longitud;
            NumCarriles = numcarr;
            Ocupacion = ocupacion;

        }
        public NivelOcupacion GetoOcupasao() { return Ocupacion; }

        internal NivelesOcupacion getOcupacion()
        {
            throw new NotImplementedException();
        }
    }
}
