namespace LIstBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxTXT.Text = string.Empty;
        }

        private void buttonLimpalista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione algo divo", "Você é besta", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTXT.TextLength == 0)
            {
                MessageBox.Show("Escreva algo divo", "Você é besta", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.Add(textBoxTXT.Text);
                textBoxTXT.Clear();
                textBoxTXT.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPosicao.Text = listBox1.SelectedIndex.ToString();
            textBoxTXTselect.Text = listBox1.SelectedItem.ToString();
            textBoxTotal.Text = listBox1.Items.Count.ToString();
        }

        private void textBoxPosicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTXTselect_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
