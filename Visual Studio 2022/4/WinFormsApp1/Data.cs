using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Data
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        public void addFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public List<Funcionario> exibirFuncionarios() 
        {
            return funcionarios;
        }
    }
}
