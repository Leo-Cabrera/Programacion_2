using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_VJ1208
{
    public partial class Form1 : Form
    {   //inicializar variables generales
        private const int anchoEsce = 735;
        private const int altoEsce = 500;
        private Marcador marcador;
        private Serpiente serpiente;
        private Comida comida;
        private const Keys arriba = Keys.Up;
        private const Keys abajo = Keys.Down;
        private const Keys izquierda = Keys.Left;
        private const Keys derecha = Keys.Right;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint
            | ControlStyles.UserPaint
            | ControlStyles.OptimizedDoubleBuffer
            | ControlStyles.SupportsTransparentBackColor, true);
            this.Text = "Serpiente VJ1208 ...";
            this.Width = anchoEsce;
            this.Height = altoEsce;
            this.BackColor = Color.DarkRed;
            serpiente = new Serpiente();
            Controls.Add(Serpiente.MiPictureBox);
            comida = new Comida();
            Controls.Add(comida.MiPictureBox);
            marcador = new Marcador();
            Controls.Add(Marcador.Marc);
            Marcador.Marc.SendToBack();
           
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:

                                        break;
                case Keys.Down:

                                        break;

                case Keys.Left:

                                        break;
                case Keys.Right:

                                        break;

            }
        }
    }   
}
