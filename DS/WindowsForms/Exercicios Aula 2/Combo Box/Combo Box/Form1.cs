namespace Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            if (TBtexto.Text.Length != 0)
            {
                comboBox1.Items.Add(TBtexto.Text);
                TBtexto.Clear();
                TBtexto.Focus();
            }
            else
            {
                MessageBox.Show("Você é besta? Escreva algo!!!",
                    "Ce é besta??",
                    MessageBoxButtons.OK);
            }

        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            TBtexto.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }

        private void BTNlimplist_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item pegado idiota", "Falha de pegamento de item", MessageBoxButtons.OK);
            }
            else
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBposicao.Text = comboBox1.SelectedIndex.ToString();
            TBtextselect.Text = comboBox1.SelectedItem.ToString();
            TBtotal.Text = comboBox1.Items.Count.ToString();
        }

        private void TBtexto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void TBtexto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BTNadd_Click(sender, e);
            }
        }
    }
}
