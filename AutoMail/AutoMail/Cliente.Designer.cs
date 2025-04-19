namespace AutoMail
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnEditar = new Button();
            btnDeshabilitarCli = new Button();
            btnNuevoCli = new Button();
            dgvClientes = new DataGridView();
            grbDatCli = new GroupBox();
            lbID = new Label();
            lblCliID = new Label();
            cmbCat = new ComboBox();
            label3 = new Label();
            cmbProv = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            txtWeb = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            btnModificar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtnomCli = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblUsuario = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbDatCli.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Maroon;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Impact", 15F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(997, 382);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(189, 80);
            btnEditar.TabIndex = 57;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitarCli
            // 
            btnDeshabilitarCli.BackColor = Color.Maroon;
            btnDeshabilitarCli.FlatAppearance.BorderSize = 0;
            btnDeshabilitarCli.FlatStyle = FlatStyle.Flat;
            btnDeshabilitarCli.Font = new Font("Impact", 15F);
            btnDeshabilitarCli.ForeColor = Color.White;
            btnDeshabilitarCli.Location = new Point(997, 258);
            btnDeshabilitarCli.Margin = new Padding(4, 5, 4, 5);
            btnDeshabilitarCli.Name = "btnDeshabilitarCli";
            btnDeshabilitarCli.Size = new Size(189, 78);
            btnDeshabilitarCli.TabIndex = 56;
            btnDeshabilitarCli.Text = "INHABILITAR";
            btnDeshabilitarCli.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCli
            // 
            btnNuevoCli.BackColor = Color.Maroon;
            btnNuevoCli.FlatAppearance.BorderSize = 0;
            btnNuevoCli.FlatStyle = FlatStyle.Flat;
            btnNuevoCli.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoCli.ForeColor = Color.White;
            btnNuevoCli.Location = new Point(997, 131);
            btnNuevoCli.Margin = new Padding(4, 5, 4, 5);
            btnNuevoCli.Name = "btnNuevoCli";
            btnNuevoCli.Size = new Size(189, 90);
            btnNuevoCli.TabIndex = 55;
            btnNuevoCli.Text = "NUEVO";
            btnNuevoCli.UseVisualStyleBackColor = false;
            btnNuevoCli.Click += btnNuevoCli_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(12, 103);
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.RowTemplate.Height = 24;
            dgvClientes.Size = new Size(949, 386);
            dgvClientes.TabIndex = 53;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // grbDatCli
            // 
            grbDatCli.BackColor = Color.White;
            grbDatCli.Controls.Add(lbID);
            grbDatCli.Controls.Add(lblCliID);
            grbDatCli.Controls.Add(cmbCat);
            grbDatCli.Controls.Add(label3);
            grbDatCli.Controls.Add(cmbProv);
            grbDatCli.Controls.Add(label6);
            grbDatCli.Controls.Add(label8);
            grbDatCli.Controls.Add(txtWeb);
            grbDatCli.Controls.Add(txtEmail);
            grbDatCli.Controls.Add(label4);
            grbDatCli.Controls.Add(btnModificar);
            grbDatCli.Controls.Add(btnCancelar);
            grbDatCli.Controls.Add(btnGuardar);
            grbDatCli.Controls.Add(txtnomCli);
            grbDatCli.Controls.Add(label1);
            grbDatCli.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDatCli.ForeColor = Color.Black;
            grbDatCli.Location = new Point(13, 511);
            grbDatCli.Margin = new Padding(4, 5, 4, 5);
            grbDatCli.Name = "grbDatCli";
            grbDatCli.Padding = new Padding(4, 5, 4, 5);
            grbDatCli.Size = new Size(1197, 278);
            grbDatCli.TabIndex = 54;
            grbDatCli.TabStop = false;
            grbDatCli.Text = "DATOS CLIENTE";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Impact", 12F);
            lbID.Location = new Point(125, 48);
            lbID.Margin = new Padding(4, 0, 4, 0);
            lbID.Name = "lbID";
            lbID.Size = new Size(34, 25);
            lbID.TabIndex = 63;
            lbID.Text = "00";
            // 
            // lblCliID
            // 
            lblCliID.AutoSize = true;
            lblCliID.Font = new Font("Impact", 12F);
            lblCliID.Location = new Point(23, 48);
            lblCliID.Margin = new Padding(4, 0, 4, 0);
            lblCliID.Name = "lblCliID";
            lblCliID.Size = new Size(94, 25);
            lblCliID.TabIndex = 62;
            lblCliID.Text = "Cliente ID:";
            // 
            // cmbCat
            // 
            cmbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCat.Font = new Font("Impact", 10.8F);
            cmbCat.FormattingEnabled = true;
            cmbCat.Location = new Point(554, 199);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(222, 30);
            cmbCat.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F);
            label3.Location = new Point(455, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 60;
            label3.Text = "Categoria:";
            // 
            // cmbProv
            // 
            cmbProv.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProv.Font = new Font("Impact", 10.8F);
            cmbProv.FormattingEnabled = true;
            cmbProv.Location = new Point(193, 199);
            cmbProv.Name = "cmbProv";
            cmbProv.Size = new Size(231, 30);
            cmbProv.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F);
            label6.Location = new Point(23, 161);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 58;
            label6.Text = "Web:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F);
            label8.Location = new Point(23, 200);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 56;
            label8.Text = "Provincia:";
            // 
            // txtWeb
            // 
            txtWeb.Font = new Font("Impact", 10.8F);
            txtWeb.Location = new Point(193, 161);
            txtWeb.Margin = new Padding(4, 5, 4, 5);
            txtWeb.Name = "txtWeb";
            txtWeb.Size = new Size(583, 29);
            txtWeb.TabIndex = 55;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Impact", 10.8F);
            txtEmail.Location = new Point(193, 122);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(583, 29);
            txtEmail.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F);
            label4.Location = new Point(23, 122);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 52;
            label4.Text = "E-Mail:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Maroon;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Impact", 13.8F, FontStyle.Italic);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(868, 103);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(305, 68);
            btnModificar.TabIndex = 51;
            btnModificar.Text = "ACTUALIZAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Maroon;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Impact", 13.8F, FontStyle.Italic);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(868, 181);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(305, 68);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Maroon;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(868, 27);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(305, 66);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "INSERTAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtnomCli
            // 
            txtnomCli.Font = new Font("Impact", 10.8F);
            txtnomCli.Location = new Point(193, 83);
            txtnomCli.Margin = new Padding(4, 5, 4, 5);
            txtnomCli.Name = "txtnomCli";
            txtnomCli.Size = new Size(583, 29);
            txtnomCli.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(23, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 39;
            label1.Text = "Nombre Cliente:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 95);
            panel1.TabIndex = 52;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(524, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 48);
            label5.TabIndex = 53;
            label5.Text = "CLIENTES";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft New Tai Lue", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(1866, 40);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(96, 30);
            lblUsuario.TabIndex = 52;
            lblUsuario.Text = "Usuario";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1339, 29);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 39);
            label7.TabIndex = 8;
            label7.Text = "CLIENTES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 806);
            Controls.Add(btnEditar);
            Controls.Add(btnDeshabilitarCli);
            Controls.Add(btnNuevoCli);
            Controls.Add(dgvClientes);
            Controls.Add(grbDatCli);
            Controls.Add(panel1);
            Name = "Cliente";
            Text = "Cliente";
            Load += Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbDatCli.ResumeLayout(false);
            grbDatCli.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditar;
        private Button btnDeshabilitarCli;
        private Button btnNuevoCli;
        private DataGridView dgvClientes;
        private GroupBox grbDatCli;
        private Button btnModificar;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtTelCli;
        private Label label3;
        private TextBox txtnomCli;
        private Label label1;
        private Panel panel1;
        private Label lblUsuario;
        private Label label7;
        private Label label5;
        private TextBox txtWeb;
        private TextBox txtEmail;
        private Label label4;
        private Label label8;
        private Label label6;
        private ComboBox cmbCat;
        private ComboBox cmbProv;
        private Label lbID;
        private Label lblCliID;
    }
}