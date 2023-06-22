using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBAS
{
    internal class Campo_de_juego
    {
        public int XMax { get; set; }
        public int YMax { get; set; }

        public Campo_de_juego(int x, int y)
        {
            XMax = x;
            YMax = y;
        }
    }
}
