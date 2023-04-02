using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_1_Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
            
        }

        private void texto1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            double cant = Convert.ToDouble(numeric.Value);
            double precio = 0;
            if (0 == cant )
            {
                precio = 0.00;

            }
            else if (0 < cant && cant < 200)
            {
                precio = 4.50;

            }
            else if (200 < cant && cant < 500)
            {
                precio = 3.75;

            }
            else if (cant > 500)
            {
                precio = 3.25;

            }

            double total =precio * cant ;
            bb.Text = total.ToString("c");
        }

        private void bb_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    
        

