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
         
            //Validaciones

            if (Numero1TextBox.Text == "")
            {
                errorProvider1.SetError(Numero1TextBox, "Favor ingresar número");
                
                return;
            
            } 
            
            
            
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

        //Para validar solo numeros
        private void Numero1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan Números","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;   

                return;
            }


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
