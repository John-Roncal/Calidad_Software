namespace AutoMail
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panLogo = new Panel();
            panPanta = new Panel();
            pictureBox1 = new PictureBox();
            btnCorreo = new Button();
            btnRes = new Button();
            btnCli = new Button();
            btnCat = new Button();
            btnPro = new Button();
            panPanta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panLogo
            // 
            panLogo.BackColor = Color.White;
            panLogo.BackgroundImage = (Image)resources.GetObject("panLogo.BackgroundImage");
            panLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panLogo.Location = new Point(0, -1);
            panLogo.Margin = new Padding(3, 2, 3, 2);
            panLogo.Name = "panLogo";
            panLogo.Size = new Size(230, 142);
            panLogo.TabIndex = 0;
            // 
            // panPanta
            // 
            panPanta.BackColor = Color.FromArgb(224, 224, 224);
            panPanta.Controls.Add(pictureBox1);
            panPanta.Location = new Point(229, -1);
            panPanta.Margin = new Padding(3, 2, 3, 2);
            panPanta.Name = "panPanta";
            panPanta.Size = new Size(1194, 629);
            panPanta.TabIndex = 1;
            panPanta.Paint += panPanta_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1203, 629);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCorreo
            // 
            btnCorreo.BackColor = Color.White;
            btnCorreo.Cursor = Cursors.Hand;
            btnCorreo.FlatAppearance.BorderSize = 0;
            btnCorreo.FlatStyle = FlatStyle.Flat;
            btnCorreo.Font = new Font("Impact", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorreo.ForeColor = Color.Black;
            btnCorreo.Image = (Image)resources.GetObject("btnCorreo.Image");
            btnCorreo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCorreo.Location = new Point(0, 154);
            btnCorreo.Margin = new Padding(4, 3, 4, 3);
            btnCorreo.Name = "btnCorreo";
            btnCorreo.Padding = new Padding(14, 0, 0, 0);
            btnCorreo.Size = new Size(223, 66);
            btnCorreo.TabIndex = 1;
            btnCorreo.Text = "     ENVIAR CORREO";
            btnCorreo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorreo.UseVisualStyleBackColor = false;
            btnCorreo.Click += btnCorreo_Click;
            // 
            // btnRes
            // 
            btnRes.BackColor = Color.White;
            btnRes.Cursor = Cursors.Hand;
            btnRes.FlatAppearance.BorderSize = 0;
            btnRes.FlatStyle = FlatStyle.Flat;
            btnRes.Font = new Font("Impact", 13.2000008F);
            btnRes.ForeColor = Color.Black;
            btnRes.Image = Properties.Resources.burbuja_de_chat;
            btnRes.ImageAlign = ContentAlignment.MiddleLeft;
            btnRes.Location = new Point(0, 218);
            btnRes.Margin = new Padding(4, 3, 4, 3);
            btnRes.Name = "btnRes";
            btnRes.Padding = new Padding(14, 0, 0, 0);
            btnRes.Size = new Size(223, 66);
            btnRes.TabIndex = 1;
            btnRes.Text = "     RESPUESTAS";
            btnRes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRes.UseVisualStyleBackColor = false;
            btnRes.Click += btnRes_Click;
            // 
            // btnCli
            // 
            btnCli.BackColor = Color.White;
            btnCli.Cursor = Cursors.Hand;
            btnCli.FlatAppearance.BorderSize = 0;
            btnCli.FlatStyle = FlatStyle.Flat;
            btnCli.Font = new Font("Impact", 13.2000008F);
            btnCli.ForeColor = Color.Black;
            btnCli.Image = Properties.Resources.nueva_cuenta__1_;
            btnCli.ImageAlign = ContentAlignment.MiddleLeft;
            btnCli.Location = new Point(0, 315);
            btnCli.Margin = new Padding(4, 3, 4, 3);
            btnCli.Name = "btnCli";
            btnCli.Padding = new Padding(14, 0, 0, 0);
            btnCli.Size = new Size(223, 66);
            btnCli.TabIndex = 3;
            btnCli.Text = "      CLIENTES";
            btnCli.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCli.UseVisualStyleBackColor = false;
            btnCli.Click += btnCli_Click;
            // 
            // btnCat
            // 
            btnCat.BackColor = Color.White;
            btnCat.Cursor = Cursors.Hand;
            btnCat.FlatAppearance.BorderSize = 0;
            btnCat.FlatStyle = FlatStyle.Flat;
            btnCat.Font = new Font("Impact", 13.2000008F);
            btnCat.ForeColor = Color.Black;
            btnCat.Image = Properties.Resources.lineas_de_opciones__1_;
            btnCat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCat.Location = new Point(0, 387);
            btnCat.Margin = new Padding(4, 3, 4, 3);
            btnCat.Name = "btnCat";
            btnCat.Padding = new Padding(14, 0, 0, 0);
            btnCat.Size = new Size(223, 66);
            btnCat.TabIndex = 4;
            btnCat.Text = "      CATEGORIAS";
            btnCat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCat.UseVisualStyleBackColor = false;
            btnCat.Click += btnCat_Click;
            // 
            // btnPro
            // 
            btnPro.BackColor = Color.White;
            btnPro.Cursor = Cursors.Hand;
            btnPro.FlatAppearance.BorderSize = 0;
            btnPro.FlatStyle = FlatStyle.Flat;
            btnPro.Font = new Font("Impact", 13.2000008F);
            btnPro.ForeColor = Color.Black;
            btnPro.Image = Properties.Resources.provincia__1_;
            btnPro.ImageAlign = ContentAlignment.MiddleLeft;
            btnPro.Location = new Point(0, 459);
            btnPro.Margin = new Padding(4, 3, 4, 3);
            btnPro.Name = "btnPro";
            btnPro.Padding = new Padding(14, 0, 0, 0);
            btnPro.Size = new Size(223, 66);
            btnPro.TabIndex = 5;
            btnPro.Text = "       PROVINCIAS";
            btnPro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPro.UseVisualStyleBackColor = false;
            btnPro.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1429, 630);
            Controls.Add(btnCorreo);
            Controls.Add(btnPro);
            Controls.Add(btnCat);
            Controls.Add(btnCli);
            Controls.Add(btnRes);
            Controls.Add(panPanta);
            Controls.Add(panLogo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "GastroMadrid";
            panPanta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panLogo;
        private Panel panPanta;
        private Button btnCorreo;
        private Button btnRes;
        private Button btnCli;
        private Button btnCat;
        private Button btnPro;
        private PictureBox pictureBox1;
    }
}
