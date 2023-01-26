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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        decimal Sumatotal = 0;

        private void SumarButton_Click(object sender, EventArgs e)
        {
            //Varables 
            decimal numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            //decimal resultado = numero1 + numero2;

            //MessageBox.Show("LA SUMA ES: " + resultado);

            //ResultadoLabel.Text = resultado.ToString();

            //Sumar(numero1, numero2);

            Sumatotal = Sumatoria(numero1, numero2);
            MessageBox.Show("La suma es: " + Sumatotal, "Resultado", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        //Procedimiento
        private void Sumar(decimal num1,decimal num2)

        {
            Sumatotal = num1 + num2;

        }

        //Función    

        private decimal Sumatoria(decimal num1, decimal num2)

        {
            //decimal n1, n2, suma;
            //n1 = num1;
            //n2 = num2;
            
            //suma = n1+n2;
            //return suma;


            return num1 + num2;       
                
        }


            
    }



}
