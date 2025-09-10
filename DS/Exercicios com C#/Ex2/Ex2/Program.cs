using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Aluno 
    {
        public int matricula;
        public string nome;
        public double nota1;
        public double nota2;
        public double media;
        public string status;

        public Aluno()
        {
        }

        public Aluno(int matricula)
        {
            this.matricula = matricula;
        }

        public Aluno(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }

        public Aluno (int matricula, string nome, double nota1, double nota2)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.media = (nota1 + nota2) / 2;
        }

        public Aluno(int matricula, string nome, double nota1, double nota2, string status)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.media = (nota1 + nota2) / 2;
            this.status = status;
        }

        public void exibirDados()
        {
            Console.WriteLine(
            $"\n*******************************\n" +
            $"Matrícula____: {matricula}\n" +
            $"Nome_________: {nome}\n" +
            $"Nota 1_______: {nota1}\n" +
            $"Nota 2_______: {nota2}\n" +
            $"Média________: {media}\n" +
            $"Status_______: {status}\n" +
            $"*********************************\n"
            );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> lista_aluno = new List<Aluno>();

            Console.WriteLine("*** Cadastro de Funcionários ***");

            do
            {
                matricula:
                Console.Write("Matricula_: ");
                int matricula = int.Parse( Console.ReadLine());
                if (matricula < 0)
                {
                    goto matricula;
                }
                nome:
                Console.Write("Nome______: ");
                string nome = Console.ReadLine();
                if (nome.Length <= 0)
                {
                    goto nome;
                }
                nota1:
                Console.Write("1ª Nota___: ");
                double nota1 = double.Parse( Console.ReadLine());
                if (nota1 < 0 || nota1 > 10)
                {
                    goto nota1;
                }
                nota2:
                Console.Write("2ª Nota___: ");
                double nota2 = double.Parse(Console.ReadLine());
                if (nota2 < 0 || nota2 > 10)
                {
                    goto nota2;
                }
                double media = (nota1 + nota2) / 2;
                string status;
                if (media >= 6)
                {
                    status = "Aprovado";
                }
                else
                {
                    status = "Reprovado";
                }

                lista_aluno.Add(new Aluno(matricula, nome, nota1, nota2, status));

                Console.Write("Cadastrar novo Aluno? (N/s)");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() != "S")
                {
                    Console.WriteLine("Cadastro finalizado!!!");
                    break;
                }
            } while (true);

            Console.Clear();
            foreach (Aluno cadaAluno in lista_aluno)
            {
                cadaAluno.exibirDados();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Fim ****");
            Console.ReadLine();
        }
    }
}
