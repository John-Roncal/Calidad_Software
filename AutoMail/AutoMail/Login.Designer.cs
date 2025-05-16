namespace AutoMail
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnLogin = new Button();
            panLogo = new Panel();
            panel1 = new Panel();
            lblIntentos = new Label();
            chkMostrarClave = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(33, 151);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(33, 228);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "CONTRASEÑA:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(33, 174);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(317, 22);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(33, 251);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(317, 22);
            txtClave.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Impact", 15F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(59, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(258, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panLogo
            // 
            panLogo.BackColor = Color.White;
            panLogo.BackgroundImage = (Image)resources.GetObject("panLogo.BackgroundImage");
            panLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panLogo.Location = new Point(121, 0);
            panLogo.Margin = new Padding(3, 2, 3, 2);
            panLogo.Name = "panLogo";
            panLogo.Size = new Size(130, 117);
            panLogo.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(-4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 116);
            panel1.TabIndex = 6;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Location = new Point(33, 128);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(12, 15);
            lblIntentos.TabIndex = 8;
            lblIntentos.Text = "-";
            // 
            // chkMostrarClave
            // 
            chkMostrarClave.AutoSize = true;
            chkMostrarClave.Location = new Point(283, 226);
            chkMostrarClave.Name = "chkMostrarClave";
            chkMostrarClave.Size = new Size(67, 19);
            chkMostrarClave.TabIndex = 9;
            chkMostrarClave.Text = "mostrar";
            chkMostrarClave.UseVisualStyleBackColor = true;
            chkMostrarClave.CheckedChanged += chkMostrarClave_CheckedChanged_1;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 376);
            Controls.Add(chkMostrarClave);
            Controls.Add(lblIntentos);
            Controls.Add(panLogo);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnLogin;
        private Panel panLogo;
        private Panel panel1;
        private Label lblIntentos;
        private CheckBox chkMostrarClave;
    }
}