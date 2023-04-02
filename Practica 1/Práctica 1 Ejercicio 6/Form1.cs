using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_ejercicio06
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            if (B1.Enabled == false)
            {
                Pantalla.Clear();
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                B4.Enabled = true;
                B5.Enabled = true;
                B6.Enabled = true;
                B7.Enabled = true;
                B8.Enabled = true;
                B9.Enabled = true;
                B0.Enabled = true;
                Bsuma.Enabled = true;
                Bresta.Enabled = true;
                Bmultiplicacion.Enabled = true;
                Bdivision.Enabled = true;
                Bpunto.Enabled = true;
                Bsigno.Enabled = true;
                Bborrar.Enabled = true;
                Bresult.Enabled = true;
            
            }

            else
            {
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                B4.Enabled = false;
                B5.Enabled = false;
                B6.Enabled = false;
                B7.Enabled = false;
                B8.Enabled = false;
                B9.Enabled = false;
                B0.Enabled = false;
                Bsuma.Enabled = false;
                Bresta.Enabled = false;
                Bmultiplicacion.Enabled = false;
                Bdivision.Enabled = false;
                Bpunto.Enabled = false;
                Bsigno.Enabled = false;
                Bborrar.Enabled = false;
                Bresult.Enabled = false;
            }



        }
        private void Pantalla_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e) // boton 1
        {
            Pantalla.Text += "1";
        }
        private void B2_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "3";
        }
        private void button1_Click(object sender, EventArgs e) // 4
        {
            Pantalla.Text += "4";
        }
        private void button2_Click(object sender, EventArgs e) // 5
        {
            Pantalla.Text += "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "9";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "0";
        }

        private void Bpunto_Click(object sender, EventArgs e)
        {
            if (!(Pantalla.Text.Contains(",")))
            {
                Pantalla.Text += ",";
            }

        }

        private void Bsuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Clear();
            operacion = "+";
            
        }

        private void Bresta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Clear();
            operacion = "-";
        }

        private void Bmultiplicacion_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Clear();
            operacion = "*";
        }

        private void button15_Click(object sender, EventArgs e) //multiplicacion
        {
            num1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Clear();
            operacion = "/";
        }
        private void Bresult_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = Convert.ToString(resultado);
            
            if (operacion == "+")
            {
                resultado = num1 +num2 ;
                Pantalla.Text = Convert.ToString(resultado);
            }
            else if(operacion == "-")
            {
                resultado = num1 -num2 ;
                Pantalla.Text = Convert.ToString(resultado);
            }
            else if (operacion == "*")
            {
                resultado = num1 * num2;
                Pantalla.Text = Convert.ToString(resultado);
            }
            else if (operacion == "/")
            {
                if( num2 == 0)
                {
                    Pantalla.Text = "ERROR";
                    Bc_Click(sender,e);
                }
                else
                {
                    resultado = num1 / num2;
                    Pantalla.Text = Convert.ToString(resultado);
                }
            }

            
            

        }
        

        private void Bborrar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Bsigno_Click(object sender, EventArgs e)
        {
            Pantalla.Text= Convert.ToString(Convert.ToDouble(Pantalla.Text)*(-1));
        }
    }
}
