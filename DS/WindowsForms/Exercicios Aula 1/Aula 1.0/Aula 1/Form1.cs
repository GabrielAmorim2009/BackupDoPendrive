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
            lblHW.Text = $"Cassino {textBox1.Text}";

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Escreve alguma coisa seu OTÀRIO");
            }
            else
            {
                MessageBox.Show("Cassinos e Roletas", "Cassino Avisa", MessageBoxButtons.OK);
            }
        }

        private void lblHW_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
