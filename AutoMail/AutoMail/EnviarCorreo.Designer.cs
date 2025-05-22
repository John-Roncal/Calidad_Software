namespace AutoMail
{
    partial class EnviarCorreo
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
            label1 = new Label();
            label2 = new Label();
            txtAsunto = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            lblUsuario = new Label();
            label7 = new Label();
            btnEnviarCor = new Button();
            btnCancelarCo = new Button();
            txtMensaje = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            cbxRecordatorio = new CheckBox();
            cbxNuevo = new CheckBox();
            cmbCategoria = new ComboBox();
            groupBox1 = new GroupBox();
            btnPasarMensaje = new Button();
            txtRespuesta = new RichTextBox();
            btnEnviarPrompt = new Button();
            label9 = new Label();
            txtPrompt = new RichTextBox();
            checkBox1 = new CheckBox();
            txtFilePath = new TextBox();
            label6 = new Label();
            btnBuscarArchivo = new Button();
            openFileDialog = new OpenFileDialog();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 216);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 0;
            label1.Text = "ASUNTO :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 277);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 1;
            label2.Text = "MENSAJE :";
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(254, 215);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(495, 27);
            txtAsunto.TabIndex = 2;
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
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1389, 83);
            panel1.TabIndex = 53;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(537, 19);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(288, 48);
            label5.TabIndex = 53;
            label5.Text = "ENVIAR CORREOS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft New Tai Lue", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(2459, 31);
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
            label7.Location = new Point(1933, 29);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 39);
            label7.TabIndex = 8;
            label7.Text = "CLIENTES";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnviarCor
            // 
            btnEnviarCor.BackColor = Color.Maroon;
            btnEnviarCor.FlatAppearance.BorderSize = 0;
            btnEnviarCor.FlatStyle = FlatStyle.Flat;
            btnEnviarCor.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviarCor.ForeColor = Color.White;
            btnEnviarCor.Location = new Point(254, 651);
            btnEnviarCor.Margin = new Padding(5, 5, 5, 5);
            btnEnviarCor.Name = "btnEnviarCor";
            btnEnviarCor.Size = new Size(146, 47);
            btnEnviarCor.TabIndex = 56;
            btnEnviarCor.Text = "ENVIAR";
            btnEnviarCor.UseVisualStyleBackColor = false;
            btnEnviarCor.Click += btnEnviarCor_Click;
            // 
            // btnCancelarCo
            // 
            btnCancelarCo.BackColor = Color.Maroon;
            btnCancelarCo.FlatAppearance.BorderSize = 0;
            btnCancelarCo.FlatStyle = FlatStyle.Flat;
            btnCancelarCo.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarCo.ForeColor = Color.White;
            btnCancelarCo.Location = new Point(601, 651);
            btnCancelarCo.Margin = new Padding(5, 5, 5, 5);
            btnCancelarCo.Name = "btnCancelarCo";
            btnCancelarCo.Size = new Size(149, 51);
            btnCancelarCo.TabIndex = 57;
            btnCancelarCo.Text = "CANCELAR";
            btnCancelarCo.UseVisualStyleBackColor = false;
            btnCancelarCo.Click += btnCancelarCo_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Font = new Font("Segoe UI", 8F);
            txtMensaje.Location = new Point(254, 276);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(495, 281);
            txtMensaje.TabIndex = 59;
            txtMensaje.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 123);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 60;
            label3.Text = "CATEGORIA :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 171);
            label4.Name = "label4";
            label4.Size = new Size(66, 30);
            label4.TabIndex = 61;
            label4.Text = "TIPO  :";
            // 
            // cbxRecordatorio
            // 
            cbxRecordatorio.AutoSize = true;
            cbxRecordatorio.Location = new Point(368, 172);
            cbxRecordatorio.Name = "cbxRecordatorio";
            cbxRecordatorio.Size = new Size(118, 24);
            cbxRecordatorio.TabIndex = 62;
            cbxRecordatorio.Text = "Recordatorio";
            cbxRecordatorio.UseVisualStyleBackColor = true;
            cbxRecordatorio.Click += cbxRecordatorio_Click;
            // 
            // cbxNuevo
            // 
            cbxNuevo.AutoSize = true;
            cbxNuevo.Location = new Point(254, 172);
            cbxNuevo.Name = "cbxNuevo";
            cbxNuevo.Size = new Size(74, 24);
            cbxNuevo.TabIndex = 63;
            cbxNuevo.Text = "Nuevo";
            cbxNuevo.UseVisualStyleBackColor = true;
            cbxNuevo.Click += cbxNuevo_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(254, 121);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(233, 28);
            cmbCategoria.TabIndex = 64;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPasarMensaje);
            groupBox1.Controls.Add(txtRespuesta);
            groupBox1.Controls.Add(btnEnviarPrompt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPrompt);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(786, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 485);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            // 
            // btnPasarMensaje
            // 
            btnPasarMensaje.Image = Properties.Resources.transferir;
            btnPasarMensaje.Location = new Point(23, 291);
            btnPasarMensaje.Name = "btnPasarMensaje";
            btnPasarMensaje.Size = new Size(61, 53);
            btnPasarMensaje.TabIndex = 68;
            btnPasarMensaje.UseVisualStyleBackColor = true;
            btnPasarMensaje.Click += btnPasarMensaje_Click;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Segoe UI", 8F);
            txtRespuesta.Location = new Point(96, 200);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.ReadOnly = true;
            txtRespuesta.Size = new Size(433, 265);
            txtRespuesta.TabIndex = 67;
            txtRespuesta.Text = "";
            // 
            // btnEnviarPrompt
            // 
            btnEnviarPrompt.Image = Properties.Resources.enviar1;
            btnEnviarPrompt.Location = new Point(469, 60);
            btnEnviarPrompt.Name = "btnEnviarPrompt";
            btnEnviarPrompt.Size = new Size(61, 53);
            btnEnviarPrompt.TabIndex = 66;
            btnEnviarPrompt.UseVisualStyleBackColor = true;
            btnEnviarPrompt.Click += btnEnviarPrompt_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 167);
            label9.Name = "label9";
            label9.Size = new Size(116, 30);
            label9.TabIndex = 64;
            label9.Text = "RESPUESTA :";
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(23, 33);
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(439, 112);
            txtPrompt.TabIndex = 63;
            txtPrompt.Text = "";
            txtPrompt.Enter += txtPrompt_Enter;
            txtPrompt.Leave += txtPrompt_Leave;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold);
            checkBox1.Location = new Point(786, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(247, 34);
            checkBox1.TabIndex = 67;
            checkBox1.Text = "GENERADOR DE MENSAJE";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(254, 597);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(348, 27);
            txtFilePath.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Myanmar Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 595);
            label6.Name = "label6";
            label6.Size = new Size(195, 30);
            label6.TabIndex = 69;
            label6.Text = "ADJUNTAR ARCHIVO :";
            // 
            // btnBuscarArchivo
            // 
            btnBuscarArchivo.Location = new Point(608, 597);
            btnBuscarArchivo.Name = "btnBuscarArchivo";
            btnBuscarArchivo.Size = new Size(141, 29);
            btnBuscarArchivo.TabIndex = 70;
            btnBuscarArchivo.Text = "Buscar Archivo";
            btnBuscarArchivo.UseVisualStyleBackColor = true;
            btnBuscarArchivo.Click += btnBuscarArchivo_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // EnviarCorreo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 711);
            Controls.Add(btnBuscarArchivo);
            Controls.Add(label6);
            Controls.Add(txtFilePath);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(cmbCategoria);
            Controls.Add(cbxNuevo);
            Controls.Add(cbxRecordatorio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMensaje);
            Controls.Add(btnCancelarCo);
            Controls.Add(btnEnviarCor);
            Controls.Add(panel1);
            Controls.Add(txtAsunto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnviarCorreo";
            Text = "EnviarCorreo";
            Load += EnviarCorreo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAsunto;
        private Panel panel1;
        private Label label5;
        private Label lblUsuario;
        private Label label7;
        private Button btnEnviarCor;
        private Button btnCancelarCo;
        private RichTextBox txtMensaje;
        private Label label3;
        private Label label4;
        private CheckBox cbxRecordatorio;
        private CheckBox cbxNuevo;
        private ComboBox cmbCategoria;
        private GroupBox groupBox1;
        private Label label9;
        private RichTextBox txtPrompt;
        private CheckBox checkBox1;
        private Button btnEnviarPrompt;
        private TextBox txtFilePath;
        private Label label6;
        private Button btnBuscarArchivo;
        private OpenFileDialog openFileDialog;
        private RichTextBox txtRespuesta;
        private Button btnPasarMensaje;
    }
}