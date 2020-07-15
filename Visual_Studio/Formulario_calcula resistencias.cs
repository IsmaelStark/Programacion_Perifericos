using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_resistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lb1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label2.BackColor = Color.FromArgb(213, 150, 0);
            //Radiob3b.Checked = true;
            list_b1.SelectedIndex = 0;
            list_b2.SelectedIndex = 0;
            list_b3.SelectedIndex = 0;
            list_b3_1.SelectedIndex = 0;
            list_b4_1.SelectedIndex = 0;
            list_b4.SelectedIndex = 0;
            list_b4_1.SelectedIndex = 0;
            list_b5.SelectedIndex = 0;
            list_b6.SelectedIndex = 0;
        }

        private void Radiob3b_CheckedChanged(object sender, EventArgs e)
        {
            //Bandas de las resistencias
            Lb4.Visible = false;
            Lb5.Visible = false;
            Lb6.Visible = false;
            //Selleccion de colores listBox
            list_b3.Visible = false;//solo para 5 y 6 bandas
            list_b4.Visible = false;
            list_b4_1.Visible = false;//solo para la resistencia de 4 badas
            list_b5.Visible = false;
            list_b6.Visible = false;
            //nombres de las bandas aariba de seleccion
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
        }

        private void Radiob4b_CheckedChanged(object sender, EventArgs e)
        {
            Lb4.Visible = true;
            Lb5.Visible = false;
            Lb6.Visible = false;

            list_b3.Visible = false;
            list_b4.Visible = false;
            list_b4_1.Visible = true;
            list_b5.Visible = false;
            list_b6.Visible = false;

            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
        }

        private void Radiob5b_CheckedChanged(object sender, EventArgs e)
        {
            Lb4.Visible = true;
            Lb5.Visible = true;
            Lb6.Visible = false;

            list_b3.Visible = true;
            list_b4.Visible = true;
            list_b5.Visible = true;
            list_b6.Visible = false;

            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = false;
        }

        private void Radiob6b_CheckedChanged(object sender, EventArgs e)
        {
            Lb4.Visible = true;
            Lb5.Visible = true;
            Lb6.Visible = true;

            list_b3.Visible = true;
            list_b4.Visible = true;
            list_b5.Visible = true;
            list_b6.Visible = true;

            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            list_b1.SelectedIndex = 0;
            list_b2.SelectedIndex = 0;
            list_b3.SelectedIndex = 0;
            list_b3_1.SelectedIndex = 0;
            list_b4_1.SelectedIndex = 0;
            list_b4.SelectedIndex = 0;
            list_b5.SelectedIndex = 0;
            list_b6.SelectedIndex = 0;
        }

        private void list_b1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b1.SelectedIndex)
            {
                case 0:
                    Lb1.BackColor = Color.Black;
                    break;
                case 1:
                    Lb1.BackColor = Color.Brown;
                    break;
                case 2:
                    //Lb1.BackColor = Color.Red;
                    Lb1.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case 3:
                    Lb1.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    Lb1.BackColor = Color.Yellow;
                    break;
                case 5:
                    //Lb1.BackColor = Color.FromArgb(0, 255, 0);
                    Lb1.BackColor = Color.FromArgb(7, 88, 39);
                    break;
                case 6:
                    Lb1.BackColor = Color.FromArgb(0, 0, 255);
                    break;
                case 7:
                    Lb1.BackColor = Color.Purple;
                    break;
                case 8:
                    Lb1.BackColor = Color.Gray;
                    break;
                case 9:
                    Lb1.BackColor = Color.White;
                    break;
            }
            VarR.vb1 = list_b1.SelectedIndex;	//para list_b1, list_b3, list_b3 se pareceran en esta parte del codigo.
            //en list_b3_1,list_b3_1, list_b5 y list_b6 deberan poner manualmente los valores a cada uno dentro del los case
            ///lblR.Text = Convert.ToString( VarR.vb1); //solo con fines de debugeo
        }
        private void list_b2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b2.SelectedIndex)
            {
                case 0:
                    Lb2.BackColor = Color.Black;
                    break;
                case 1:
                    Lb2.BackColor = Color.Brown;
                    break;
                case 2:
                    //Lb1.BackColor = Color.Red;
                    Lb2.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case 3:
                    Lb2.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    Lb2.BackColor = Color.Yellow;
                    break;
                case 5:
                    //Lb2.BackColor = Color.FromArgb(0, 255, 0);
                    Lb2.BackColor = Color.FromArgb(7, 88, 39);
                    break;
                case 6:
                    Lb2.BackColor = Color.FromArgb(0, 0, 255);
                    break;
                case 7:
                    Lb2.BackColor = Color.Purple;
                    break;
                case 8:
                    Lb2.BackColor = Color.Gray;
                    break;
                case 9:
                    Lb2.BackColor = Color.White;
                    break;
            }
            VarR.vb2 = list_b2.SelectedIndex;
        }

        private void list_b3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b3.SelectedIndex)
            {
                case 0:
                    Lb3.BackColor = Color.Black;
                    break;
                case 1:
                    Lb3.BackColor = Color.Brown;
                    break;
                case 2:
                    //Lb3.BackColor = Color.Red;
                    Lb3.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case 3:
                    Lb3.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    Lb3.BackColor = Color.Yellow;
                    break;
                case 5:
                    //Lb3.BackColor = Color.FromArgb(0, 255, 0);
                    Lb3.BackColor = Color.FromArgb(7, 88, 39);
                    break;
                case 6:
                    Lb3.BackColor = Color.FromArgb(0, 0, 255);
                    break;
                case 7:
                    Lb3.BackColor = Color.Purple;
                    break;
                case 8:
                    Lb3.BackColor = Color.Gray;
                    break;
                case 9:
                    Lb3.BackColor = Color.White;
                    break;
            }
            VarR.vb3 = list_b3.SelectedIndex;
        }

        private void list_b3_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b3_1.SelectedIndex)
            {
                case 0:
                    Lb3.BackColor = Color.Black;
                    break;
                case 1:
                    Lb3.BackColor = Color.Brown;
                    break;
                case 2:
                    //Lb3.BackColor = Color.Red;
                    Lb3.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case 3:
                    Lb3.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    Lb3.BackColor = Color.Yellow;
                    break;
                case 5:
                    Lb3.BackColor = Color.Gold;
                    //Lb4.BackColor = Color.Goldenrod;
                    break;
                case 6:
                    Lb3.BackColor = Color.Silver;
                    break;
                default:
                    Lb3.BackColor = Color.Black;
                    break;
            }
        }

        private void list_b4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b4.SelectedIndex)
            {
                case 0:
                    Lb4.BackColor = Color.Black;
                    break;
                case 1:
                    Lb4.BackColor = Color.Brown;
                    break;
                case 2:
                    //Lb4.BackColor = Color.Red;
                    Lb4.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case 3:
                    Lb4.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    Lb4.BackColor = Color.Yellow;
                    break;
                case 5:
                    Lb4.BackColor = Color.Gold;
                    //Lb4.BackColor = Color.Goldenrod;
                    break;
                case 6:
                    Lb4.BackColor = Color.Silver;
                    break;
                default:
                    Lb4.BackColor = Color.Black;
                    break;
            }
        }

        private void list_b4_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b4_1.SelectedIndex)
            {
                case 0:
                    Lb4.BackColor = Color.Brown;
                    break;
                case 1:
                    //Lb4.BackColor = Color.Red;
                    Lb4.BackColor = Color.FromArgb(255, 0, 0);
                    break;
                case 2:
                    Lb4.BackColor = Color.Gold;
                    //Lb4.BackColor = Color.Goldenrod;
                    break;
                case 3:
                    Lb4.BackColor = Color.Silver;
                    break;

            }
        }
        private void list_b5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b5.SelectedIndex)
            {
                case 0:
                    Lb5.BackColor = Color.Brown;
                    break;
                case 1:
                    Lb5.BackColor = Color.Red;
                    break;
                case 2:
                    Lb5.BackColor = Color.Gold;
                    //Lb5.BackColor = Color.Goldenrod;
                    break;
                case 3:
                    Lb5.BackColor = Color.Silver;
                    break;
            }
        }

        private void list_b6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_b6.SelectedIndex)
            {
                case 0:
                    VarR.vb2 = 100;
                    Lb6.BackColor = Color.Brown;
                    break;
                case 1:
                    VarR.vb2 = 50;
                    Lb6.BackColor = Color.Red;
                    break;
                case 2:
                    Lb6.BackColor = Color.Yellow;
                    break;
                case 3:
                    Lb6.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    Lb6.BackColor = Color.Blue;
                    break;
                case 5:
                    Lb6.BackColor = Color.Purple;
                    break;
                case 6:
                    Lb6.BackColor = Color.White;
                    break;
            }
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if(Radiob3b.Checked == true)
            {
                Calcular_3Bandas();
            }
            else if (Radiob4b.Checked == true)
            {
                Calcular_4Bandas();
            }
            else if (Radiob5b.Checked == true)
            {
                Calcular_5Bandas();
            }
            else if (Radiob6b.Checked == true)
            {
                Calcular_6Bandas();
            }
            else
            {
                MessageBox.Show("Debes seleccionar que banda vas a calcular primero");
            }
        }

        private void Calcular_3Bandas()
        {
            //lblR.Text = Convert.ToString((VarR.vb1 * 100) + (VarR.vb2 * 10) + (VarR.vb3));

        }
        private void Calcular_4Bandas()
        {
           // lblR.Text = Convert.ToString((VarR.vb1 * 100) + (VarR.vb2 * 10) + (VarR.vb3));

        }
        private void Calcular_5Bandas()
        {

        }
        private void Calcular_6Bandas()
        {

        }

    }
}

public static class VarR//clase que contiene las variables globales
{
    public static int vb1 = 0;
    public static int vb2 = 0;
    public static int vb3 = 0;
    public static int vb3_1 = 0;	//variables para los listbox ocultos que se usaran
    public static int vb4_1 = 0;	//en la de 3 y 4 bandas
    public static int vb4 = 0;
    public static int vb5 = 0;
    public static int vb6 = 0;
    public static int resultado = 0;
}

//los Lb1.....al Lb6 son los labels que use para dibujar mi resistencia
// los list_b1 al list_b6 son los listbox
//los label8, label9 y label10 son lo que estan arriba de los listbox y son los que contienen el texto del numero de banda
//los Radiob3b al Radiob6b son los radiobutton que me ayudaran aseleccionar el tipo de resistencia a calcular