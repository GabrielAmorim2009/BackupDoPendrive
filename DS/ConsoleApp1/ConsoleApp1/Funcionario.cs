using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Funcionario
    {
        public static string nome;

        public void setNome(string _nome)
        {
            nome = _nome;
        }

        public string getNome()
        {
            return nome;
        }
    }
}
