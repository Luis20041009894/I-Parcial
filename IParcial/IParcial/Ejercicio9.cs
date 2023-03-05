using Programacion_orientada_a_objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        Coche miCoche = null;
        List<Coche> ListaCoches = new List<Coche>();

        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche();
            //Coche miCoche2 = new Coche("Toyota", "22R");

            string marca = MarcaTextBox.Text;
            string modelo = MarcaTextBox.Text;
            //Con validación para cuando este vacio y asignar cero // forma avanzada del Ing Nahum Casco / no se usa if and else
            decimal precio = PrecioTextBox.Text == string.Empty ? 0 : Convert.ToDecimal(PrecioTextBox.Text);
            int km = KilometrosTextBox.Text == string.Empty ? 0 : Convert.ToInt32(KilometrosTextBox.Text);

            //Instanciar

            miCoche = new Coche();

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = km;

            ListaCoches.Add(miCoche);
            CochesDataGridView.DataSource = null;
            CochesDataGridView.DataSource = ListaCoches;
            LimpiarControles();
            MarcaTextBox.Focus();

            // MessageBox.Show("Objeto Coche -> Marca: " + miCoche.Marca + " Modelo:  " + miCoche.Modelo);

        }

        private void LimpiarControles()
        {
            MarcaTextBox.Clear();
            ModeloTextBox.Clear();
            PrecioTextBox.Clear();
            KilometrosTextBox.Clear();

        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {
            MarcaTextBox.Focus();
        }
    }
}
