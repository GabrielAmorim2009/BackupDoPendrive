using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Helper.output("***** Ler dados *****");

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //p1.nome = Helper.input("Digite o nome da 1ª pessoa ");
            //p2.nome = Helper.input("Digite o nome da 2ª pessoa ");
            //Helper.output($"Seja bem vindos(as) {p1.nome} e {p2.nome}");

            ////Helper2 helper2 = new Helper2();
            ////helper2.output("***** Ler dados *****");
            ////string nome = helper2.input("Digite o nome: ");
            ////helper2.output("Seja bem vindo(a) " + nome);

            //Console.ReadLine();

            //Helper.output("***** Ler dados *****");
            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //f1.setNome("Joaquin");
            //f2.setNome("Maria");

            //Helper.output(
            //    $"Sejam bem vindos(as) " +
            //    $"{f1.getNome()} e {f2.getNome()}"
            //);
            //Console.ReadLine();
            //Helper.output("*************************");

            //Helper.valorGlobal = Helper.input("Digite um valor: ");

            //Form1 form1 = new Form1();
            //form1.ShowDialog();

            //cadastrar um animal lagartixa de parede

            Animal animal = new Animal("Lagartixa de Parede", "De Parede");
            animal.nome += " Leonardo Diamante Cravejado";
            animal.tipo += " De Parede";

            Animal animal_listar = new Animal();
            animal_listar.ConsultarTodos();
        }
    }
}
