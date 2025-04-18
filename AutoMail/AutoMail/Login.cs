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
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtClave.Text;

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
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
