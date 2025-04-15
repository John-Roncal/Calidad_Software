using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMail
{
    public partial class Provincia : Form
    {
        public Provincia()
        {
            InitializeComponent();
            listarProv();
            grbProv.Enabled = false;
        }


        public void listarProv()
        {
            dgvProv.DataSource = logProvincia.Instancia.ListarProvincia();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodProv.Text.Trim();
                string nombreProv = txtnomProv.Text.Trim();

                if (string.IsNullOrEmpty(nombreProv))
                {
                    MessageBox.Show("El nombre de la provincia no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }

                /*if (logCategoria.Instancia.ExisteNombreCategoria(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría ya existe. Por favor, elija otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                else
                {
                    entProvincia p = new entProvincia();
                    p.Codigo = codigo;
                    p.NombreProv = nombreProv;
                    p.Estado = true;
                    logProvincia.Instancia.InsertaProvincia(p);
                    LimpiarVariables();
                    grbProv.Enabled = false;
                    listarProv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            grbProv.Enabled = false;
            listarProv();
        }

        public void LimpiarVariables()
        {

            txtnomProv.Clear();
            txtCodProv.Clear();
        }

        private void btnDeshabilitarProv_Click(object sender, EventArgs e)
        {
            try
            {
                entProvincia p = new entProvincia();
                p.Codigo = txtCodProv.Text.Trim();
                logProvincia.Instancia.DeshabilitarProvincia(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbProv.Enabled = false;
            listarProv();
        }

        private void btnNuevaProv_Click(object sender, EventArgs e)
        {
            grbProv.Enabled = true;
            btnGuardar.Visible = true;
            txtCodProv.Enabled = true;
            btnModificar.Visible = false;
            LimpiarVariables();
        }

        private void btnEditarProv_Click(object sender, EventArgs e)
        {
            grbProv.Enabled = true;
            btnModificar.Visible = true;
            btnGuardar.Visible = false;
            txtCodProv.Enabled = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnModificar.Visible = true;
            grbProv.Enabled = false;
            LimpiarVariables();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProvincia pro = new entProvincia();
                pro.Codigo = txtCodProv.Text.Trim();
                pro.NombreProv = txtnomProv.Text.Trim();
                logProvincia.Instancia.EditarProvincia(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbProv.Enabled = false;
            listarProv();
        }

        private void dgvProv_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProv.Enabled = false;
            DataGridViewRow filaActual = dgvProv.Rows[e.RowIndex];
            txtCodProv.Text = filaActual.Cells[0].Value.ToString();
            txtnomProv.Text = filaActual.Cells[1].Value.ToString();
        }
    }

}
