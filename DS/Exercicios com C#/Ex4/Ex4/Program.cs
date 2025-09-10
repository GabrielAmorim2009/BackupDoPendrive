using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Banco
    {
        public int numeroConta;
        public string nome;
        public double saldo;
        public double valorDeposito;
        public double valorSaque;

        public Banco () { }

        public Banco(int numeroConta)
        {
            this.numeroConta = numeroConta;
        }

        public Banco (int numeroConta, string nome)
        {
            this.numeroConta = numeroConta;
            this.nome = nome;
        }

        public Banco (int numeroConta, string nome, double saldo)
        {
            this.numeroConta = numeroConta;
            this.nome = nome;
            this.saldo = saldo;
        }

        public Banco(int numeroConta, string nome, double saldo, double valorDeposito, double valorSaque)
        {
            this.numeroConta = numeroConta;
            this.nome = nome;
            this.saldo = saldo;
            this.valorDeposito = valorDeposito;
            this.valorSaque = valorSaque;
        }

        public void Depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;
        }
            
        public void Sacar(double valorSacar)
        {
            if (this.saldo > valorSacar)
            {
                this.saldo -= valorSacar;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você é pobre, não tem dinheiro suficiente!!!");
                Console.ReadKey();
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Este é o seu saldo: {this.saldo.ToString("C")}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            Console.WriteLine("Nome do cliente ________:");
            string nome = Console.ReadLine();
            Console.WriteLine("Número da conta ________:");
            int numeroConta = int.Parse(Console.ReadLine());

            acao:

            Console.WriteLine("*** Escolha sua ação *** \n" +
                              "1 => Depositar _________ \n" +
                              "2 => Sacar _____________ \n" +
                              "3 => Exibir Saldo ______ \n" +
                              "5 => Sair ______________ \n");
            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Qual o valor a ser depositado?");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    banco.Depositar(valorDeposito);
                    Console.Write("Quer fazer mais uma ação: ");
                    string respostaDeposito = Console.ReadLine();
                    if (respostaDeposito == "S" || respostaDeposito == "s")
                    {
                        Console.Clear();
                        goto acao;
                    }
                    else
                    {
                        goto fim;
                    }
                    break;
                case "2":
                    saque:
                    Console.Clear();
                    Console.WriteLine("Qual o valor a ser sacado?");
                    double valorSaque = double.Parse(Console.ReadLine());
                    banco.Sacar(valorSaque);
                    Console.Write("Quer fazer mais uma ação: ");
                    string respostaSaque = Console.ReadLine();
                    if (respostaSaque == "S" || respostaSaque == "s")
                    {
                        Console.Clear();
                        goto acao;
                    }
                    else
                    {
                        goto fim;
                    }
                    break;
                case "3":
                    Console.Clear();
                    banco.ExibirSaldo();
                    Console.Write("Quer fazer mais uma ação: ");
                    string respostaSaldo = Console.ReadLine();
                    if (respostaSaldo == "S" || respostaSaldo == "s")
                    {
                        Console.Clear();
                        goto acao;
                    }
                    else
                    {
                        goto fim;
                    }
                    break;
                case "4":

                    break;
                case "5":
                    fim:
                    Console.Clear();
                    Console.Write("\nPressione qualquer tecla para sair");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    goto acao;
            }

        }
    }
}
