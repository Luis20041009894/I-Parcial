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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void ArreglosButton_Click(object sender, EventArgs e)
        {
            //Vectores
            int[] vector = new int[5];

            vector[0] = 10;
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 40;
            vector[4] = 50;

            int[] vector2 = new int[5] {10,20,30,40,50 };
            int[] vector3 = new int[] { 10, 20, 30, 40, 50 };
            int[] vector4 = { 10, 20, 30, 40, 50 };

            string[] vector5 = { "Maria", "Marta", "Juan", "Luis", "Esteban" };

            for (int i = 0; i < vector5.Length; i++)
            {
                ArregloListBox.Items.Add(vector5[i]);
                
            }
            // FOR avanzado para arreglos.... La palabra reservada "var" detecta el tipo de dato, string o int,,, es mejor
            foreach (var item in vector5) 
            {
                ArregloComboBox.Items.Add(item);


            }

        }
    }
}
