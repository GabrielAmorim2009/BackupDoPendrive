using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Funcionario
    {
        public int matricula;
        public string nome;
        public double valorHora;
        public int horasTrab;
        public double salario;

        //Construtor base
        public Funcionario() {
        }

        //Construtor que exige a matrícula
        public Funcionario(int matricula)
        {
            this.matricula = matricula;
        }
        //Sobrecarga de construtor;
        public Funcionario(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }

        public Funcionario(int matricula, string nome, double valorHora)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.valorHora = valorHora;
        }

        public Funcionario(int matricula, string nome, double valorHora, int horasTrab)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.valorHora = valorHora;
            this.horasTrab = horasTrab;
            this.salario = valorHora * horasTrab;
        }

        public void exibirDados()
        {
            Console.WriteLine(
            $"\n*******************************\n" +
            $"Matrícula________: {matricula}\n" +
            $"Nome_____________: {nome}\n" +
            $"Valor hora_______: {valorHora}\n" +
            $"Horas trabalhadas: {horasTrab}\n" +
            $"Salário: {salario.ToString("C")}\n" +
            $"*********************************"
            );
        }
    }
    internal class Program{
        static void Main(string[] args){
            List<Funcionario> lista_func = new List<Funcionario>();

            Console.WriteLine("*** Cadastro de Funcionários ***");
            do{
                //Lógica para cadastro de funcionário
                //Construimos uma instância do funcionário;
                //    Funcionario funcionario = new Funcionario();    
                //Carregando a matrículo para o objeto func criado;
                //    Console.Write("Matrícula_: ");
                //    funcionario.matricula = int.Parse(Console.ReadLine());
                //Carregando a nome para o objeto func criado;
                //    Console.Write("Nome______: ");
                //    funcionario.nome = Console.ReadLine();
                //Carregando a valorHora para o objeto func criado;
                //    Console.Write("Valor hora: R$");
                //    funcionario.valorHora = double.Parse(Console.ReadLine());
                //Adcionando o funcionário criado para lista;
                //    lista_func.Add(funcionario);
                //Lógica para criar novo o func o partir para a exibição;

                matricula:
                Console.Write("Digite a matrícula do funcionário______: ");
                int matricula = int.Parse( Console.ReadLine());
                Console.Write("Digite o nome do funcionário___________: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor hora do funcionário_____: ");
                double valorHora = double.Parse( Console.ReadLine());
                Console.Write("Digite a hora trabalhada do funcionário: ");
                int horasTrab = int.Parse(Console.ReadLine());

                lista_func.Add(new Funcionario(matricula, nome, valorHora, horasTrab));

                Console.Write("Cadastrar novo funcionário? (N/s)");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() != "S"){
                    Console.WriteLine("Cadastro finalizado!!!");  
                    break;                    
                }
                } while (true);

            //for (int id = 0; id < lista_Func.Count; id++)
            //{
            //    Console.WriteLine(
            //        $"Matícula: {lista_Func[id].matricula}"+
            //        $" Nome: {lista_Func[id].nome}"+
            //        $" Valor hora: {lista_Func[id].valorHora}"
            //    );
            //}

            Console.Clear();
            foreach (Funcionario cadaFunc in lista_func)
            {
                cadaFunc.exibirDados();
            }

            Console.WriteLine("\n*** Fim ****");
            Console.ReadLine();
        }
    }
}
