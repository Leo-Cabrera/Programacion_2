using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_VJ1208
{
    internal class Segmento
    {
        public PictureBox segmento;

        public Segmento(int x, int y, Color color, Point size) 
        {
            segmento.Location = new System.Drawing.Point(x,y);
            segmento.BackColor = color;
            segmento.Size = new System.Drawing.Size(size);

        }
    }
}
