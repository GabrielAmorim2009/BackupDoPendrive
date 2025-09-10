namespace Message_Boxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Esta é uma mensagem de alerta.", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string message = "Poderia informar seus dados para futuro contato?";
            string caption = "Pergunta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("OK Obrigado! Em breve entrarei  em contato!", "Resposta SIM", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("OK Sem problemas! ", "Resposta NÃO",
                MessageBoxButtons.OK);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("É isso mesmo que pensou?",
                             "Pergunta",
                             MessageBoxButtons.YesNoCancel,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button2);
        }
    }
}
