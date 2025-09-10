using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Veiculo
    {
        public string placa;
        public string modelo;
        public int ano;
        public double valorDiaria;
        public double valorLocacao;

        public Veiculo() { }

        public Veiculo(string placa)
        {
            this.placa = placa;
        }

        public Veiculo(string placa, string modelo)
        {
            this.placa = placa;
            this.modelo = modelo;
        }

        public Veiculo(string placa, string modelo, int ano)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.ano = ano;
        }

        public Veiculo(string placa, string modelo, int ano, double valorDiaria)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.ano = ano;
            this.valorDiaria = valorDiaria;
        }

        public Veiculo(string placa, string modelo, int ano, double valorDiaria, double valorLocacao)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.ano = ano;
            this.valorDiaria = valorDiaria;
            this.valorLocacao = valorLocacao;
        }

        public void exibirDados()
        {
            Console.WriteLine(
            $"\n************************\n" +
            $"Placa_________: {placa}\n" +
            $"Modelo________: {modelo}\n" +
            $"Ano___________: {ano}\n" +
            $"Valor Diária__: {valorDiaria}\n" +
            $"Valor Locacao_: {valorLocacao}\n" +
            $"**************************"
            );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> lista_veiculo = new List<Veiculo>();

            Console.WriteLine("*** Cadastro de Veículos ***");

            do
            {
            placa:
                Console.Write("Placa________: ");
                string placa = Console.ReadLine();
                if (placa.Length < 0)
                {
                    goto placa;
                }
            modelo:
                Console.Write("Modelo_______: ");
                string modelo = Console.ReadLine();
                if (modelo.Length <= 0)
                {
                    goto modelo;
                }
            ano:
                Console.Write("Ano__________: ");
                int ano = int.Parse(Console.ReadLine());
                if (ano < 0)
                {
                    goto ano;
                }
            valorDiaria:
                Console.Write("Valor Diária_: ");
                double valorDiaria = double.Parse(Console.ReadLine());
                if (valorDiaria < 0)
                {
                    goto valorDiaria;
                }
                double valorLocacao = valorDiaria * 5;

                lista_veiculo.Add(new Veiculo(placa, modelo, ano, valorDiaria, valorLocacao));

                Console.Write("Cadastrar novo carro? (N/s)");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() != "S")
                {
                    Console.WriteLine("Cadastro finalizado!!!");
                    break;
                }
            } while (true);

            Console.Clear();
            foreach (Veiculo cadaVeiculo in lista_veiculo)
            {
                cadaVeiculo.exibirDados();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**** Fim ****");
            Console.ReadLine();
        }
    }
}
