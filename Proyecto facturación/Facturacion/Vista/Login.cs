using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese su nombre de usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (ContraseñaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese su contraseña");
                ContraseñaTextBox.Clear();
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //Validar en la base de datos

            // Mostrar el Menu

            Menu menuFormulario = new Menu();
            Hide();
            menuFormulario.Show();

        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';

            }
            else
            {
                ContraseñaTextBox.PasswordChar += '*';
            }
        }
    }
}
