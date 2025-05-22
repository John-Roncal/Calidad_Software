using CapaDatos;
using CapaEntidad;
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

namespace AutoMail
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
            listarCategoria();
            grbDatCat.Enabled = false;
        }

        public void listarCategoria()
        {
            dgvCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCategoria = txtnomCat.Text.Trim();

                if (string.IsNullOrEmpty(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //return;
                }

                /*if (logCategoria.Instancia.ExisteNombreCategoria(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría ya existe. Por favor, elija otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                else
                {
                    entCategoria cat = new entCategoria();
                    cat.Nombre = nombreCategoria;
                    cat.Estado = true;
                    logCategoria.Instancia.InsertaCategoria(cat);
                    LimpiarVariables();
                    grbDatCat.Enabled = false;
                    listarCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarVariables();
            grbDatCat.Enabled = false;
            listarCategoria();
        }

        private void btnNuevaCat_Click(object sender, EventArgs e)
        {
            grbDatCat.Enabled = true;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
        }

        public void LimpiarVariables()
        {
            lbCat.Text = "00";
            txtnomCat.Clear();
        }

        private void btnDeshabilitarCat_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria cat = new entCategoria();
                cat.Id = int.Parse(lbCat.Text.Trim());
                logCategoria.Instancia.DeshabilitarCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarVariables();
            grbDatCat.Enabled = false;
            listarCategoria();
        }

        private void btnEditarCat_Click(object sender, EventArgs e)
        {
            grbDatCat.Enabled = true;
            btnModificar.Visible = true;
            btnGuardar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria cat = new entCategoria();
                cat.Id = int.Parse(lbCat.Text.Trim());
                cat.Nombre = txtnomCat.Text.Trim();
                logCategoria.Instancia.EditarCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarVariables();
            grbDatCat.Enabled = false;
            listarCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grbDatCat.Enabled = false;
            btnModificar.Visible = true;
            btnGuardar.Visible = true;
            LimpiarVariables();
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoria.Rows[e.RowIndex];
            lbCat.Text = filaActual.Cells[0].Value.ToString();
            txtnomCat.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}
