namespace AutoMail
{
    public partial class Menu : Form
    {
        private Form activeForm;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EnviarCorreo());
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cliente());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panPanta.Controls.Add(childForm);
            this.panPanta.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Categoria());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Provincia());
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yo soy Axl Rose");
        }

        private void panPanta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
