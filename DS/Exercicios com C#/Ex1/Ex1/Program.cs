using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Produto
    {
        public int codigo;
        public string nome;
        public double precoBase;
        public double percentualLucro;
        public double precoFinal;

        public Produto()
        {
        }

        public Produto(int codigo)
        {
            this.codigo = codigo;
        }

        public Produto(int codigo, string nome)
        {
            this.codigo = codigo;
        }

        public Produto(int codigo, string nome, double precoBase)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.precoBase = precoBase;
        }

        public Produto(int codigo, string nome, double precoBase, double percentualLucro)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.precoBase = precoBase;
            this.percentualLucro = percentualLucro;
        }

        public Produto(int codigo, string nome, double precoBase, double percentualLucro, double precoFinal)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.precoBase = precoBase;
            this.percentualLucro = percentualLucro;
            this.precoFinal = precoBase * (percentualLucro / 100 + 1);
        }

        public void exibirDados()
        {
            Console.WriteLine(
            $"*******************************\n" +
            $"Código___________: {codigo}\n" +
            $"Nome_____________: {nome}\n" +
            $"Preco base_______: {precoBase.ToString("C")}\n" +
            $"Percentual lucro_: {percentualLucro}\n" +
            $"Preço final______: {precoFinal.ToString("C")}\n" +
            $"*******************************\n"
            );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista_prod = new List<Produto>();

            Console.WriteLine("*** Cadastro de Produtos ***");
            do
            {
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

                Console.Write("Digite o código do produto_________: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do produto___________: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o preço base do produto_____: ");
                double precoBase = double.Parse(Console.ReadLine());
                Console.Write("Digite o percentual de lucro_______: ");
                int percentualLucro = int.Parse(Console.ReadLine());
                double precoFinal = precoBase * (percentualLucro / 100 + 1);

                lista_prod.Add(new Produto(codigo, nome, precoBase, percentualLucro, precoFinal));

                Console.Write("Cadastrar novo produto? (N/s)");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() != "S")
                {
                    Console.WriteLine("Cadastro finalizado!!!");
                    break;
                }
            } while (true);

            Console.Clear();
            foreach (Produto cadaProd in lista_prod)
            {
                cadaProd.exibirDados();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Fim ****");
            Console.ReadLine();
        }
    }
}
