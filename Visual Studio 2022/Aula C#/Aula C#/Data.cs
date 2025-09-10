using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_C_
{
    internal class Data
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();
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
