namespace Aula_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void lb_nome_Click(object sender, EventArgs e)
        {

        }

        private void lb_cargo_Click(object sender, EventArgs e)
        {

        }

        private void lb_salario_Click(object sender, EventArgs e)
        {

        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            obj_func.id = int.Parse(tb_id.Text);
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            obj_func.nome = tb_nome.Text;
        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_func.cargo = cb_cargo.Text;
        }

        private void tb_salario_TextChanged(object sender, EventArgs e)
        {
            obj_func.salario = double.Parse(tb_salario.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj_func.verDados();
        }

        Funcionario obj_func = new Funcionario();

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_cargo.Items.Add("Apostador Junior");
            cb_cargo.Items.Add("Apostador Senior");
            cb_cargo.Items.Add("Auxiliar de Apostas");
            cb_cargo.Items.Add("Diretor de Apostas");
            cb_cargo.Items.Add("Dono do Cassino");
        }
    }
}
