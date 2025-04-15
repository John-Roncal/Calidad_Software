using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoMail
{
    public partial class EnviarCorreo : Form
    {
        public EnviarCorreo()
        {
            InitializeComponent();
        }

        private void btnCancelarCo_Click(object sender, EventArgs e)
        {
            txtAsunto.Clear();
            txtMensaje.Clear();
            txtAsunto.Focus();
        }

        private void EnviarCorreo_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = logCategoria.Instancia.CargarCategoria();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";

            cbxNuevo.Checked = true;


            // Configura el texto inicial del TextBox
            txtPrompt.Text = " Escribe el formato del mensaje ...";
            txtPrompt.ForeColor = SystemColors.GrayText;
        }

        private void cbxRecordatorio_Click(object sender, EventArgs e)
        {
            cbxNuevo.Checked = false;
        }

        private void cbxNuevo_Click(object sender, EventArgs e)
        {
            cbxRecordatorio.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBox1.Checked;
        }

        private void txtPrompt_Enter(object sender, EventArgs e)
        {
            if (txtPrompt.Text == " Escribe el formato del mensaje ...")
            {
                txtPrompt.Text = "";
                txtPrompt.ForeColor = SystemColors.WindowText; // Cambia el color del texto
            }
        }

        private void txtPrompt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrompt.Text))
            {
                txtPrompt.Text = " Escribe el formato del mensaje ...";
                txtPrompt.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }

        private string TipoCorreo()
        {
            if (cbxNuevo.Checked == true)
            {
                return "Nuevo";
            }
            else
            {
                return "Enviado";
            }
        }

        private async void btnEnviarCor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAsunto.Text) || string.IsNullOrWhiteSpace(txtMensaje.Text) ||
                cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                string resultado = await datAPI.Instancia.EnviarCorreoAsync(
                    Convert.ToInt32(cmbCategoria.SelectedValue),
                    TipoCorreo(),
                    txtAsunto.Text,
                    txtMensaje.Text,
                    txtFilePath.Text);

                MessageBox.Show(resultado, "Correos enviados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                openFileDialog.Title = "Seleccionar lista de precios";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private async void btnEnviarPrompt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrompt.Text))
            {
                MessageBox.Show("Por favor, ingresa un prompt para la IA.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                txtRespuesta.Text = await datAPI.Instancia.GenerarContenidoAsync(txtPrompt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnPasarMensaje_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = txtRespuesta.Text;
            txtRespuesta.Clear();
        }
    }
}
