namespace Aula_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSairbtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblHW.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHW.Text = "Cassino";
        }
    }
}
