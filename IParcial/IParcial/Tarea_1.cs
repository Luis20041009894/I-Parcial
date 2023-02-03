using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Tarea_1 : Form
    {
        public Tarea_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variable 
            //decimal numero1 = Convert.ToInt32(Numero1TextBox.Text);

            int numero = 0;

            numero = Convert.ToInt32(Numero1TextBox.Text);

            ///// Par o Impar
            if (numero % 2 == 0) {
                ParoImparTextBox.Text = "Numero Par";
                       
            }
            else
            {
                ParoImparTextBox.Text = "Numero Impar";
            }

            ////Negativo o Positivo

            if (numero > 0)
            {
                PosNegaTextBox.Text = "Positivo";

            }
            else
            {
                PosNegaTextBox.Text = "Negativo";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParoImparTextBox.Clear();
            PosNegaTextBox.Clear();
            Numero1TextBox.Clear();

           
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Funcion
        //private static bool EsPar(int numeropar)
        //{ 
        //    if((numeropar%2)==0)
        //    {

        //    return true;

        //    }
        //    else
        //    {
        //    return false;

        //    }


        //}


    }


}
