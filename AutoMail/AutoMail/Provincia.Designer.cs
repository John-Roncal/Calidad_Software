namespace AutoMail
{
    partial class Provincia
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
            btnEditarProv = new Button();
            btnDeshabilitarProv = new Button();
            btnNuevaProv = new Button();
            dgvProv = new DataGridView();
            grbProv = new GroupBox();
            txtCodProv = new TextBox();
            label4 = new Label();
            btnModificar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtnomProv = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblUsuario = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProv).BeginInit();
            grbProv.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditarProv
            // 
            btnEditarProv.BackColor = Color.Maroon;
            btnEditarProv.FlatAppearance.BorderSize = 0;
            btnEditarProv.FlatStyle = FlatStyle.Flat;
            btnEditarProv.Font = new Font("Impact", 15F);
            btnEditarProv.ForeColor = Color.White;
            btnEditarProv.Location = new Point(997, 419);
            btnEditarProv.Margin = new Padding(5);
            btnEditarProv.Name = "btnEditarProv";
            btnEditarProv.Size = new Size(189, 80);
            btnEditarProv.TabIndex = 63;
            btnEditarProv.Text = "EDITAR";
            btnEditarProv.UseVisualStyleBackColor = false;
            btnEditarProv.Click += btnEditarProv_Click;
            // 
            // btnDeshabilitarProv
            // 
            btnDeshabilitarProv.BackColor = Color.Maroon;
            btnDeshabilitarProv.FlatAppearance.BorderSize = 0;
            btnDeshabilitarProv.FlatStyle = FlatStyle.Flat;
            btnDeshabilitarProv.Font = new Font("Impact", 15F);
            btnDeshabilitarProv.ForeColor = Color.White;
            btnDeshabilitarProv.Location = new Point(997, 293);
            btnDeshabilitarProv.Margin = new Padding(5);
            btnDeshabilitarProv.Name = "btnDeshabilitarProv";
            btnDeshabilitarProv.Size = new Size(189, 77);
            btnDeshabilitarProv.TabIndex = 62;
            btnDeshabilitarProv.Text = "INHABILITAR";
            btnDeshabilitarProv.UseVisualStyleBackColor = false;
            btnDeshabilitarProv.Click += btnDeshabilitarProv_Click;
            // 
            // btnNuevaProv
            // 
            btnNuevaProv.BackColor = Color.Maroon;
            btnNuevaProv.FlatAppearance.BorderSize = 0;
            btnNuevaProv.FlatStyle = FlatStyle.Flat;
            btnNuevaProv.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaProv.ForeColor = Color.White;
            btnNuevaProv.Location = new Point(997, 167);
            btnNuevaProv.Margin = new Padding(5);
            btnNuevaProv.Name = "btnNuevaProv";
            btnNuevaProv.Size = new Size(189, 91);
            btnNuevaProv.TabIndex = 61;
            btnNuevaProv.Text = "NUEVO";
            btnNuevaProv.UseVisualStyleBackColor = false;
            btnNuevaProv.Click += btnNuevaProv_Click;
            // 
            // dgvProv
            // 
            dgvProv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProv.BackgroundColor = Color.White;
            dgvProv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProv.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProv.EnableHeadersVisualStyles = false;
            dgvProv.Location = new Point(11, 139);
            dgvProv.Name = "dgvProv";
            dgvProv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProv.RowHeadersWidth = 51;
            dgvProv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProv.RowTemplate.Height = 24;
            dgvProv.Size = new Size(949, 387);
            dgvProv.TabIndex = 59;
            dgvProv.CellDoubleClick += dgvProv_CellDoubleClick_1;
            // 
            // grbProv
            // 
            grbProv.BackColor = Color.White;
            grbProv.Controls.Add(txtCodProv);
            grbProv.Controls.Add(label4);
            grbProv.Controls.Add(btnModificar);
            grbProv.Controls.Add(btnCancelar);
            grbProv.Controls.Add(btnGuardar);
            grbProv.Controls.Add(txtnomProv);
            grbProv.Controls.Add(label1);
            grbProv.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbProv.ForeColor = Color.Black;
            grbProv.Location = new Point(13, 547);
            grbProv.Margin = new Padding(5);
            grbProv.Name = "grbProv";
            grbProv.Padding = new Padding(5);
            grbProv.Size = new Size(1210, 165);
            grbProv.TabIndex = 60;
            grbProv.TabStop = false;
            grbProv.Text = "DATOS PROVINCIA";
            // 
            // txtCodProv
            // 
            txtCodProv.Font = new Font("Impact", 10.8F);
            txtCodProv.Location = new Point(129, 88);
            txtCodProv.Margin = new Padding(5);
            txtCodProv.Name = "txtCodProv";
            txtCodProv.Size = new Size(95, 29);
            txtCodProv.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F);
            label4.Location = new Point(29, 88);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 52;
            label4.Text = "Codigo:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Maroon;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Impact", 13.8F, FontStyle.Italic);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(704, 49);
            btnModificar.Margin = new Padding(5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(232, 68);
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
            btnCancelar.Location = new Point(960, 51);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(232, 68);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Maroon;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(446, 51);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(232, 67);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "INSERTAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtnomProv
            // 
            txtnomProv.Font = new Font("Impact", 10.8F);
            txtnomProv.Location = new Point(129, 49);
            txtnomProv.Margin = new Padding(5);
            txtnomProv.Name = "txtnomProv";
            txtnomProv.Size = new Size(271, 29);
            txtnomProv.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(29, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 39;
            label1.Text = "Provincia:";
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
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1237, 95);
            panel1.TabIndex = 58;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(514, 24);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 48);
            label5.TabIndex = 53;
            label5.Text = "PROVINCIAS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft New Tai Lue", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(2384, 37);
            lblUsuario.Margin = new Padding(5, 0, 5, 0);
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
            label7.Location = new Point(1857, 29);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 39);
            label7.TabIndex = 8;
            label7.Text = "CLIENTES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Provincia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 729);
            Controls.Add(btnEditarProv);
            Controls.Add(btnDeshabilitarProv);
            Controls.Add(btnNuevaProv);
            Controls.Add(dgvProv);
            Controls.Add(grbProv);
            Controls.Add(panel1);
            Name = "Provincia";
            Text = "Provincia";
            ((System.ComponentModel.ISupportInitialize)dgvProv).EndInit();
            grbProv.ResumeLayout(false);
            grbProv.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditarProv;
        private Button btnDeshabilitarProv;
        private Button btnNuevaProv;
        private DataGridView dgvProv;
        private GroupBox grbProv;
        private TextBox txtCodProv;
        private Label label4;
        private Button btnModificar;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtnomProv;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private Label lblUsuario;
        private Label label7;
    }
}