namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Funcionario obj_func = new Funcionario();
        private void Form1_Load(object sender, EventArgs e)
        {
            cb_cargo.Items.Add("Auxiliar docente");
            cb_cargo.Items.Add("Professor");
            cb_cargo.Items.Add("Coordenador");
            cb_cargo.Items.Add("Diretor");
        }
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            obj_func.id = int.Parse(txt_id.Text);
        }
        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            obj_func.nome = txt_nome.Text;
        }
        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_func.cargo = cb_cargo.Text;
        }
        private void txt_salario_TextChanged(object sender, EventArgs e)
        {
            obj_func.salario = double.Parse(txt_salario.Text);
        }
        private void btn_ver_Click(object sender, EventArgs e)
        {
            obj_func.verDados();
        }

        Data data = new Data();

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            data.addFuncionario(obj_func);
            int quant = data.exibirFuncionarios().Count();

            MessageBox.Show("" + quant);
        }
    }
}
