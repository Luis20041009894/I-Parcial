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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {

            if (Numero1TextBox.Text == "")
            {
                errorProvider1.SetError(Numero1TextBox, "Seleccion un valor");
                return;
               
            }

            if (Numero2TextBox.Text == "")
            {
                errorProvider1.SetError(Numero2TextBox, "Selecione un valor");
                return;
            }

            if (OperacionesComboBox.Text == "")
            {
                errorProvider1.SetError(OperacionesComboBox, "Selecione una Opción");
                return;
            }
            errorProvider1.Clear();
            

            decimal resultado = Ejecutar(Convert.ToDecimal(Numero1TextBox.Text), Convert.ToDecimal(Numero2TextBox.Text));

            ResultadoLabel.Text = Convert.ToString(resultado); 


        }

        decimal Ejecutar(decimal n1, decimal n2) 
        {
            string operacion = OperacionesComboBox.Text;
            decimal resultado = 0;

            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicación")
            {
                resultado = n1 * n2;
            }
            else if (operacion == "División")
            
            {
                resultado = n1 / n2;

            }
            return resultado;


                }
        private decimal Ejecutar2(decimal n1, decimal n2)
        {
            string operacion = OperacionesComboBox.Text;
            decimal resultado = 0;
            if (operacion == "Suma")
                resultado= n1 + n2;
            else if (operacion == "Resta")
                resultado= n1 - n2;
            else if (operacion == "Multiplicación")
                resultado= n1 * n2;
            else if (operacion == "División")
                resultado= n1 / n2; 
            return resultado;
        }


    }

        
        
}



    

