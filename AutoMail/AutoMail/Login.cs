using CapaLogica;
using CapaEntidad;
using System;
using System.Windows.Forms;
namespace AutoMail
{
    public partial class Login : Form
    {
        // Variable para controlar el número de intentos
        private int intentosRestantes = 5;

        public Login()
        {
            InitializeComponent();
            txtClave.PasswordChar = '*'; // Oculta la contraseña

            // Inicializamos el label de intentos
            ActualizarLabelIntentos();
        }

        // Método para actualizar el label con los intentos restantes
        private void ActualizarLabelIntentos()
        {
            lblIntentos.Text = $"Intentos restantes: {intentosRestantes}";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtClave.Text;

            // Verificamos si todavía tiene intentos disponibles
            if (intentosRestantes <= 0)
            {
                MessageBox.Show("Ha excedido el número máximo de intentos. La aplicación se cerrará.",
                               "Acceso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            if (logUsuario.Instancia.ValidarCredenciales(nombreUsuario, contraseña))
            {
                // Obtener el ID del rol del usuario (ya no es tipoUsuarioID)
                int rolID = logUsuario.Instancia.ObtenerRolIDPorNombre(nombreUsuario);
                // Pasamos el rolID al formulario principal
                Menu frm = new Menu(rolID);
                this.Hide();
                frm.Show();
            }
            else
            {
                // Decrementamos el contador de intentos
                intentosRestantes--;
                ActualizarLabelIntentos();

                if (intentosRestantes > 0)
                {
                    MessageBox.Show($"Credenciales incorrectas. Le quedan {intentosRestantes} intentos.",
                                   "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ha excedido el número máximo de intentos. La aplicación se cerrará.",
                                   "Acceso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void chkMostrarClave_CheckedChanged_1(object sender, EventArgs e)
        {
            // Si el checkbox está marcado, muestra la contraseña, de lo contrario la oculta
            txtClave.PasswordChar = chkMostrarClave.Checked ? '\0' : '*';
        }
    }
}