using CapaLogica;
using CapaEntidad;
using System;
using System.Windows.Forms;
using CapaLogica;

namespace AutoMail
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtClave.PasswordChar = '*'; // Oculta la contraseña
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contraseña = txtClave.Text;

            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor ingresa nombre de usuario y contraseña.");
                return;
            }

            try
            {
                // Validar credenciales con hash en la lógica
                bool esValido = logUsuario.Instancia.ValidarCredenciales(nombreUsuario, contraseña);

                if (esValido)
                {
                    MessageBox.Show("Credenciales Correctas.");
                    //entUsuario usuario = logUsuario.Instancia.ObtenerUsuarioPorNombre(nombreUsuario);
                    //if (usuario != null && usuario.estUsuario) // Verifica que esté activo
                    //{
                    //    MAIN_Interfaz frm = new MAIN_Interfaz(usuario.TipoUsuarioID);
                    //    this.Hide();
                    //    frm.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("El usuario está deshabilitado.");
                    //}
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }
    }
}
