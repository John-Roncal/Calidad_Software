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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            grbDatCli.Enabled = false;
            lblCliID.Visible = false;
            lbID.Visible = false;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cmbCat.DataSource = logCategoria.Instancia.CargarCategoria();
            cmbCat.DisplayMember = "Nombre";
            cmbCat.ValueMember = "Id";

            cmbProv.DataSource = logProvincia.Instancia.CargarProvincia();
            cmbProv.DisplayMember = "Nombre";
            cmbProv.ValueMember = "Codigo";

            ConfigurarDataGridView();
            listarCliente();
        }

        private void ConfigurarDataGridView()
        {
            // Desactivar autogeneración de columnas
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            // Configurar cada columna manualmente
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "Id"; // Propiedad de entCliente
            colId.Width = 50;
            //colId.Visible = false; // Si no quieres mostrar el ID
            dgvClientes.Columns.Add(colId);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre"; // Propiedad de entCliente
            colNombre.Width = 150;
            dgvClientes.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colMail = new DataGridViewTextBoxColumn();
            colMail.HeaderText = "Email";
            colMail.DataPropertyName = "Mail"; // Propiedad de entCliente
            colMail.Width = 300;
            dgvClientes.Columns.Add(colMail);

            DataGridViewTextBoxColumn colWeb = new DataGridViewTextBoxColumn();
            colWeb.HeaderText = "Web";
            colWeb.DataPropertyName = "Web"; // Propiedad de entCliente
            colWeb.Width = 200;
            dgvClientes.Columns.Add(colWeb);

            DataGridViewTextBoxColumn colCategoriaId = new DataGridViewTextBoxColumn();
            colCategoriaId.HeaderText = "Categoría ID";
            colCategoriaId.DataPropertyName = "IDCategoria"; // Propiedad anidada
            colCategoriaId.Visible = false;
            dgvClientes.Columns.Add(colCategoriaId);

            DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.HeaderText = "Categoría";
            colCategoria.DataPropertyName = "NombreCategoria"; // Propiedad anidada
            dgvClientes.Columns.Add(colCategoria);

            DataGridViewTextBoxColumn colProvinciaId = new DataGridViewTextBoxColumn();
            colProvinciaId.HeaderText = "Provincia Codigo";
            colProvinciaId.DataPropertyName = "IDProvincia"; // Propiedad anidada
            colProvinciaId.Visible = false;
            dgvClientes.Columns.Add(colProvinciaId);

            DataGridViewTextBoxColumn colProvincia = new DataGridViewTextBoxColumn();
            colProvincia.HeaderText = "Provincia";
            colProvincia.DataPropertyName = "NombreProvincia"; // Propiedad anidada
            colProvincia.Width = 120;
            dgvClientes.Columns.Add(colProvincia);

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.HeaderText = "Fecha de Creación";
            colFecha.DataPropertyName = "FechaCreacion"; // Propiedad de entCliente
            colFecha.Width = 180;
            dgvClientes.Columns.Add(colFecha);
        }

        public void LimpiarVariables()
        {
            txtnomCli.Clear();
            txtEmail.Clear();
            txtWeb.Clear();

            // cmbProv.Items.Clear();
        }
        public void listarCliente()
        {
            try
            {
                dgvClientes.DataSource = logCliente.Instancia.ListarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCliente = txtnomCli.Text.Trim();

                if (string.IsNullOrEmpty(nombreCliente))
                {
                    MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }

                /*if (logCategoria.Instancia.ExisteNombreCategoria(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría ya existe. Por favor, elija otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                else
                {
                    entCliente cli = new entCliente();
                    entCategoria cat = new entCategoria();
                    entProvincia pro = new entProvincia();
                    cli.Nombre = nombreCliente;
                    cli.Mail = txtEmail.Text.Trim();
                    cli.Web = txtWeb.Text.Trim();
                    pro.Codigo = cmbProv.SelectedValue.ToString();
                    cli.provincia = pro;
                    cat.Id = Convert.ToInt32(cmbCat.SelectedValue);
                    cli.categoria = cat;

                    cli.Estado = true;
                    logCliente.Instancia.InsertarCliente(cli);
                    LimpiarVariables();
                    grbDatCli.Enabled = false;
                    listarCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            LimpiarVariables();
            grbDatCli.Enabled = false;
            listarCliente();
        }

        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            grbDatCli.Enabled = true;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
            lblCliID.Visible = false;
            lbID.Visible = false;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grbDatCli.Enabled = true;
            btnModificar.Visible = true;
            btnGuardar.Visible = false;
            lblCliID.Visible = true;
            lbID.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cli = new entCliente();
                entCategoria cat = new entCategoria();
                entProvincia pro = new entProvincia();
                cli.Id = Convert.ToInt32(lbID.Text);
                cli.Nombre = txtnomCli.Text.Trim();
                cli.Mail = txtEmail.Text.Trim();
                cli.Web = txtWeb.Text.Trim();
                pro.Codigo = cmbProv.SelectedValue.ToString();
                cli.provincia = pro;
                cat.Id = Convert.ToInt32(cmbCat.SelectedValue);
                cli.categoria = cat;
                logCliente.Instancia.EditarCliente(cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grbDatCli.Enabled = false;
            listarCliente();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita errores si se hace clic en el encabezado
            {
                DataGridViewRow filaActual = dgvClientes.Rows[e.RowIndex];

                lbID.Text = filaActual.Cells[0].Value.ToString();
                txtnomCli.Text = filaActual.Cells[1].Value.ToString();
                txtEmail.Text = filaActual.Cells[2].Value.ToString();
                txtWeb.Text = filaActual.Cells[3].Value.ToString();

                int categoriaId = Convert.ToInt32(filaActual.Cells[4].Value);
                cmbCat.SelectedValue = categoriaId;

                var provinciaCodigo = filaActual.Cells[6].Value;
                cmbProv.SelectedValue = provinciaCodigo;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnModificar.Visible = true;
            LimpiarVariables();
            lblCliID.Visible = false;
            lbID.Visible = false;
            grbDatCli.Enabled = false;
        }
    }
}
