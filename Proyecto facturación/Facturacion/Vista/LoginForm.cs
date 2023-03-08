using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
                //ContraseñaTextBox.Clear();
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //Validar en la base de datos

            Login login = new Login(UsuarioTextBox.Text, ContraseñaTextBox.Text);
            Usuario usuario = new Usuario();
            UsuarioDB usuariodb = new UsuarioDB();

            usuario = usuariodb.Autenticar(login);

            if (usuario != null)
            {
                if (usuario.EstadoActivo)
                {
                    // Mostrar el Menu
                    Menu menuFormulario = new Menu();
                    this.Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no esta Activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Focus();
        }
    }
}
