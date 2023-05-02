using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_VJ1208
{
    internal class Marcador
    {
        public System.Windows.Forms.Label Marc;
        public int puntos;
        public double T_vida;

        public Marcador()
        {
            Marc.Location = new System.Drawing.Point(30, 30);
            puntos = 0;
            T_vida = 10;
            Marc.Font = new Font("Courier", 18);
            Marc.AutoSize = true;

        }

        public void mas_vida(int valor)
        {
            puntos += valor;
        }
        

    }
}
