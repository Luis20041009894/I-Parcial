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
            decimal numero1 = Convert.ToInt32(Numero1TextBox.Text);


            EsPar(Top)  
        }
       
        
        //Funcion
        private static bool EsPar(int numeropar)
        { 
            if((numeropar%2)==0)
            {
            
            return true;
            
            }
            else
            {
            return false;

            }
                
                
        }


    }


}
