namespace AutoMail
{
    partial class Categoria
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
            btnEditarCat = new Button();
            btnDeshabilitarCat = new Button();
            btnNuevaCat = new Button();
            dgvCategoria = new DataGridView();
            grbDatCat = new GroupBox();
            lbCat = new Label();
            label4 = new Label();
            btnModificar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtnomCat = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblUsuario = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            grbDatCat.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditarCat
            // 
            btnEditarCat.BackColor = Color.Maroon;
            btnEditarCat.FlatAppearance.BorderSize = 0;
            btnEditarCat.FlatStyle = FlatStyle.Flat;
            btnEditarCat.Font = new Font("Impact", 15F);
            btnEditarCat.ForeColor = Color.White;
            btnEditarCat.Location = new Point(997, 412);
            btnEditarCat.Margin = new Padding(4, 5, 4, 5);
            btnEditarCat.Name = "btnEditarCat";
            btnEditarCat.Size = new Size(189, 80);
            btnEditarCat.TabIndex = 69;
            btnEditarCat.Text = "EDITAR";
            btnEditarCat.UseVisualStyleBackColor = false;
            btnEditarCat.Click += btnEditarCat_Click;
            // 
            // btnDeshabilitarCat
            // 
            btnDeshabilitarCat.BackColor = Color.Maroon;
            btnDeshabilitarCat.FlatAppearance.BorderSize = 0;
            btnDeshabilitarCat.FlatStyle = FlatStyle.Flat;
            btnDeshabilitarCat.Font = new Font("Impact", 15F);
            btnDeshabilitarCat.ForeColor = Color.White;
            btnDeshabilitarCat.Location = new Point(997, 288);
            btnDeshabilitarCat.Margin = new Padding(4, 5, 4, 5);
            btnDeshabilitarCat.Name = "btnDeshabilitarCat";
            btnDeshabilitarCat.Size = new Size(189, 78);
            btnDeshabilitarCat.TabIndex = 68;
            btnDeshabilitarCat.Text = "INHABILITAR";
            btnDeshabilitarCat.UseVisualStyleBackColor = false;
            btnDeshabilitarCat.Click += btnDeshabilitarCat_Click;
            // 
            // btnNuevaCat
            // 
            btnNuevaCat.BackColor = Color.Maroon;
            btnNuevaCat.FlatAppearance.BorderSize = 0;
            btnNuevaCat.FlatStyle = FlatStyle.Flat;
            btnNuevaCat.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaCat.ForeColor = Color.White;
            btnNuevaCat.Location = new Point(997, 161);
            btnNuevaCat.Margin = new Padding(4, 5, 4, 5);
            btnNuevaCat.Name = "btnNuevaCat";
            btnNuevaCat.Size = new Size(189, 90);
            btnNuevaCat.TabIndex = 67;
            btnNuevaCat.Text = "NUEVO";
            btnNuevaCat.UseVisualStyleBackColor = false;
            btnNuevaCat.Click += btnNuevaCat_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategoria.BackgroundColor = Color.White;
            dgvCategoria.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategoria.EnableHeadersVisualStyles = false;
            dgvCategoria.Location = new Point(12, 133);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategoria.RowTemplate.Height = 24;
            dgvCategoria.Size = new Size(949, 386);
            dgvCategoria.TabIndex = 65;
            dgvCategoria.CellDoubleClick += dgvCategoria_CellDoubleClick;
            // 
            // grbDatCat
            // 
            grbDatCat.BackColor = Color.White;
            grbDatCat.Controls.Add(lbCat);
            grbDatCat.Controls.Add(label4);
            grbDatCat.Controls.Add(btnModificar);
            grbDatCat.Controls.Add(btnCancelar);
            grbDatCat.Controls.Add(btnGuardar);
            grbDatCat.Controls.Add(txtnomCat);
            grbDatCat.Controls.Add(label1);
            grbDatCat.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDatCat.ForeColor = Color.Black;
            grbDatCat.Location = new Point(13, 541);
            grbDatCat.Margin = new Padding(4, 5, 4, 5);
            grbDatCat.Name = "grbDatCat";
            grbDatCat.Padding = new Padding(4, 5, 4, 5);
            grbDatCat.Size = new Size(1210, 172);
            grbDatCat.TabIndex = 66;
            grbDatCat.TabStop = false;
            grbDatCat.Text = "DATOS CATEGORIA";
            // 
            // lbCat
            // 
            lbCat.AutoSize = true;
            lbCat.Font = new Font("Impact", 12F);
            lbCat.Location = new Point(60, 49);
            lbCat.Margin = new Padding(4, 0, 4, 0);
            lbCat.Name = "lbCat";
            lbCat.Size = new Size(34, 25);
            lbCat.TabIndex = 53;
            lbCat.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F);
            label4.Location = new Point(19, 49);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 52;
            label4.Text = "ID:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Maroon;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Impact", 13.8F, FontStyle.Italic);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(674, 57);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
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
            btnCancelar.Location = new Point(930, 58);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(232, 68);
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
            btnGuardar.Location = new Point(416, 58);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(232, 66);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "INSERTAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtnomCat
            // 
            txtnomCat.Font = new Font("Myanmar Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnomCat.Location = new Point(19, 121);
            txtnomCat.Margin = new Padding(4, 5, 4, 5);
            txtnomCat.Name = "txtnomCat";
            txtnomCat.Size = new Size(272, 41);
            txtnomCat.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(19, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 39;
            label1.Text = "Nombre Categoria:";
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
            panel1.Size = new Size(1237, 95);
            panel1.TabIndex = 64;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(510, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 48);
            label5.TabIndex = 53;
            label5.Text = "CATEGORIAS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft New Tai Lue", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(2902, 34);
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
            label7.Location = new Point(2375, 29);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 39);
            label7.TabIndex = 8;
            label7.Text = "CLIENTES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 716);
            Controls.Add(btnEditarCat);
            Controls.Add(btnDeshabilitarCat);
            Controls.Add(btnNuevaCat);
            Controls.Add(dgvCategoria);
            Controls.Add(grbDatCat);
            Controls.Add(panel1);
            Name = "Categoria";
            Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            grbDatCat.ResumeLayout(false);
            grbDatCat.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditarCat;
        private Button btnDeshabilitarCat;
        private Button btnNuevaCat;
        private DataGridView dgvCategoria;
        private GroupBox grbDatCat;
        private Label lbCat;
        private Label label4;
        private Button btnModificar;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtnomCat;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private Label lblUsuario;
        private Label label7;
    }
}