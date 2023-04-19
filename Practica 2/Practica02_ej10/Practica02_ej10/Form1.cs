using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace Practica02_ej10
{
    public partial class Form1 : Form
    {


        
        public int[,] matriz = new int[,] { { 0, 0, 0, 0, }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };


        public Form1()
        {

            int[,] lose = new int[,] { { 0, 0 }, { 0, 0 } };
            int[,] winm = new int[,] { { 1, 1 }, { 1, 1 } };
            matriz = MatrizEnteros.Nrandom(matriz);
            if (matriz == lose)
            {
                Lose.Visible = true;
            }
            else if (matriz == winm)
            {
                Win.Visible = true;
            }
            Label[,] matrizLabel = new Label[,]
            {
                {C0_0,C0_1, C0_2, C0_3},
                {C1_0, C1_1, C1_2, C1_3},
                {C2_0, C2_1, C2_2, C2_3},
                {C3_0, C3_1 , C3_2, C3_3},
            };

            Mostrar(matrizLabel);

            C0_0.Text = Convert.ToString(matrizLabel[0, 0]);
            C0_1.Text = Convert.ToString(matrizLabel[0, 1]);
            C0_2.Text = Convert.ToString(matrizLabel[0, 2]);
            C0_3.Text = Convert.ToString(matrizLabel[0, 3]);
            C1_0.Text = Convert.ToString(matrizLabel[1, 0]);
            C1_1.Text = Convert.ToString(matrizLabel[1, 1]);
            C1_2.Text = Convert.ToString(matrizLabel[1, 2]);
            C1_3.Text = Convert.ToString(matrizLabel[1, 3]);
            C2_0.Text = Convert.ToString(matrizLabel[2, 0]);
            C2_1.Text = Convert.ToString(matrizLabel[2, 1]);
            C2_2.Text = Convert.ToString(matrizLabel[2, 2]);
            C2_3.Text = Convert.ToString(matrizLabel[2, 3]);
            C3_0.Text = Convert.ToString(matrizLabel[3, 0]);
            C3_1.Text = Convert.ToString(matrizLabel[3, 1]);
            C3_2.Text = Convert.ToString(matrizLabel[3, 2]);
            C3_3.Text = Convert.ToString(matrizLabel[3, 3]);

            InitializeComponent();


        }
        private void Up_Click(object sender, EventArgs e)
        {
            matriz = MatrizEnteros.Arriba(matriz);





        }

        private void Left_Click(object sender, EventArgs e)
        {
            matriz = MatrizEnteros.Izquierda(matriz);

        }

        private void Down_Click(object sender, EventArgs e)
        {
            matriz = MatrizEnteros.Abajo(matriz);

        }

        private void Right_Click(object sender, EventArgs e)
        {
            matriz = MatrizEnteros.Derecha(matriz);
        }



        private void C0_3_Click(object sender, EventArgs e)
        {


        }




        private void C1_3_Click(object sender, EventArgs e)
        {

        }



        private void C2_3_Click(object sender, EventArgs e)
        {

        }

        private void C3_0_Click(object sender, EventArgs e)
        {

        }

        private void C3_1_Click(object sender, EventArgs e)
        {

        }

        private void C3_2_Click(object sender, EventArgs e)
        {
        }

        private void C3_3_Click(object sender, EventArgs e)
        {

        }

        public void Mostrar(Label[,] matrizLabel)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Label n = new Label();
                    n.Text = Convert.ToString(matriz[i, j]);
                    matrizLabel[i, j] = n;
                    if (matriz[i, j] != 0)
                    {

                        switch (matriz[i, j])
                        {
                            case 2:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.LightCyan;

                                break;

                            case 4:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.PaleTurquoise;
                                break;
                            case 8:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.Aquamarine;
                                break;
                            case 16:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.MediumAquamarine;
                                break;
                            case 32:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.MediumTurquoise;
                                break;
                            case 64:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.LightSeaGreen;
                                break;
                            case 128:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.DarkTurquoise;
                                break;
                            case 256:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.Teal;
                                break;
                            case 512:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.DarkCyan;
                                break;
                            case 1024:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.CadetBlue;
                                break;
                            case 2048:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.DarkSlateGray;
                                break;
                            case 0:
                                matrizLabel[i, j].Text = n.Text;
                                matrizLabel[i, j].BackColor = Color.DarkGray;
                                break;

                        }
                    }
                }
            }

        }

        private void Lose_TextChanged(object sender, EventArgs e)
        {

        }

        private void Win_TextChanged(object sender, EventArgs e)
        {

        }
    }
}