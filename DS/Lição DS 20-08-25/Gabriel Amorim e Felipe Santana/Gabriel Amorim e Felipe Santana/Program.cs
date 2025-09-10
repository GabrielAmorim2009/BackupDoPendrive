using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Amorim_e_Felipe_Santana
{
    public class Funcionario
    {
        public int id;
        public string nome;
        public string cargo;
        public double salarioBase;
        public int horasExtras;
        public double bonus;

        public Funcionario() { }

        public Funcionario(int id)
        {
            this.id = id;
        }

        public Funcionario(int id, string nome, string cargo, double salarioBase, int horasExtras, double bonus)
        {
            this.id = id;
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
            this.horasExtras = horasExtras;
            this.bonus = bonus;
        }
    }
    public class Empresa
    {
        public List<Funcionario> funcionarios;

        //o Métodos para adicionar, remover, buscar, atualizar e calcular folha

        public void adicionarFunc(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public void removerFunc(int id) 
        { 
        }

        public void buscarFunc()
        {

        }

        public void atualizarFunc()
        {

        }

        public void calcularFolha()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("" +
                "================================\n" +
                "1 Adicionar Funcionário\n" +
                "2 Remover Funcionário\n" +
                "3 Buscar Funcionário por ID\n" +
                "4 Atualizar Salário Base\n" +
                "5 Adicionar Bônus\n" +
                "6 Adicionar Horas Extras\n" +
                "7 Mostrar Todos os Funcionários\n" +
                "8 Calcular Total da Folha\n" +
                "9 Sair\n" +
                "================================\n" +
                "Escolha uma opção...");
                string opcao = Console.ReadLine();
                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Console.WriteLine()");
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        break;
                    case "8":
                        Console.Clear();
                        break;
                    case "9":
                        Console.Clear();
                        break;
                }
            }
            while (true);
        }
    }
}
