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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechaDateTimePicker1.Value; 
            
            DiaTextBox.Text = fecha.Day.ToString();
            MesTextBox.Text = fecha.ToString("MMMM");
            AnioTextBox.Text = fecha.Year.ToString();
            SemanaTextBox.Text = fecha.ToString("dddd");

            int numeroDias = Convert.ToInt32(DiasTextBox.Text);
            DateTime fechaActual = DateTime.Now;
                        
            
            CitaTextBox.Text = fechaActual.AddDays(numeroDias).ToShortDateString();
            
            int diasresta = Convert.ToInt32(DiasRestaTextBox.Text);

            NuevaFechaTextBox.Text = fecha.AddDays(-diasresta).ToLongDateString();

            MessageBox.Show("La edad es: " + DevolverEdad(fecha));
        }

        private int DevolverEdad(DateTime FechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (FechaNacimiento >= fechaActual)
            {
              return 0;

            }
            else
            {
                edad = fechaActual.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Month > fechaActual.Month) {
                    --edad;
                                
                }
                return edad;
            }

        }


        }


    }

