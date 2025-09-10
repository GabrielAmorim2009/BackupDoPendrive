using System.Security.Cryptography;

namespace Cadastro_de_Veiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GboxDados_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        //public string modelo = txtmodelo.Text;
        //public string ano = cbano.Text;
        //public string placa = txtplaca.Text;
        //public string cor = txtcor.Text;
        //public string[] estado = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
        //public string cidade = txtcidadecarro.Text;
        //public string nome = txtnomepessoa.Text;
        //public string endereco = txtenderecopessoa.Text;
        //public string bairro = txtbairro.Text;
        //public string complemento = txtcomplemento.Text;
        //public string[] estadop = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" }; ;
        //public string rg = txtrg.Text;
        //public string cpf = txtcpf.Text;

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Cadastro realizado com sucesso!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("___Dados do Veiculo___\n" +
                "Modelo: " + txtmodelo.Text + "\n" +
                "Ano: " + cbano.Text + "\n" +
                "Placa: " + txtplaca.Text + "\n" +
                "Fabricante: " + cbfabricante.Text + "\n" +
                "Cor: " + txtcor.Text + "\n" +
                "Estado: " + cbestadocarro.Text + "\n" +
                "Cidade: " + txtcidadecarro.Text + "\n" +
                "___Dados da Pessoa___\n" +
                "Nome: " + txtnomepessoa.Text + "\n" +
                "Endereço: " + txtenderecopessoa.Text + "\n" +
                "Bairro: " + txtbairro.Text + "\n" +
                "Complemento: " + txtcomplemento.Text + "\n" +
                "Estado: " + cbestadopessoa.Text + "\n" +
                "RG: " + txtrg.Text + "\n" +
                "CPF: " + txtcpf.Text + "\n" +
                "Genero: " + genero + "\n" +
                "Data Nascimento" + dateTimePicker1 + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btncarregarcarro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnlimparcarro_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btncarregarpessoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnlimparpessoa_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtmodelo.Text = string.Empty;
            cbano.Text = string.Empty;
            txtplaca.Text = string.Empty;
            cbfabricante.Text = string.Empty;
            txtcor.Text = string.Empty;
            cbestadocarro.Text = string.Empty;
            txtcidadecarro.Text = string.Empty;
            txtnomepessoa.Text = string.Empty;
            txtenderecopessoa.Text = string.Empty;
            txtbairro.Text = string.Empty;
            txtcomplemento.Text = string.Empty;
            cbestadopessoa.Text = string.Empty;
            txtrg.Text = string.Empty;
            txtcpf.Text = string.Empty;
            pictureBox1 = null;
            pictureBox2 = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string genero;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Masculino";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Feminino";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excluido com sucesso kkkk");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public string[] fabricante = { "Alfa Romeo", "Audi", "BMW", "Cross Lander", "Citroën", "DaimlerChrysler", "Ferrari", "Fiat", "Ford", "General Motors", "Honda", "Hyundai", "Jaguar", "Kia", "Land Rover", "Mitsubishi", "Nissan", "Peugeot", "Porsche", "Renault", "Seat", "SsangYong", "Subaru", "Toyota", "Troller", "Volkswagen", "Volvo", "CassinoCustoms" };
        public string[] estado = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

        private void Form1_Load(object sender, EventArgs e) 
        {
            foreach (string fabricantes in fabricante)
            {
                cbfabricante.Items.Add(fabricantes);
            }
            foreach (string estados in estado)
            {
                cbestadocarro.Items.Add(estados);
                cbestadopessoa.Items.Add(estados);
            }

            for (int ano = DateTime.Now.Year; ano > 1950; ano--) 
            {
                cbano.Items.Add(ano);
            }
        }



    }
}
