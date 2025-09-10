using Imagens.Properties;
using System.Security.Cryptography;

namespace Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void radioClaro_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void cbTrocaImagem_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.GrafittiKings;
        }
    }
}
