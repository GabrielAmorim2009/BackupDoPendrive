using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_DS_03_09_25
{
    internal class Funcionario
    {
        private ulong cpf;
        private string nome;
        private short idade;

        public Funcionario() { }

        public Funcionario(ulong cpf)
        {
            validarCPF(cpf);
        }

        public Funcionario(ulong cpf, string nome, short idade)
        {
            validarCPF(cpf);
            setNome(nome);
            validarIdade(idade);
        }

        public bool validarCPF(ulong cpf)
        {
            string _cpf = cpf.ToString();
            return (_cpf.Length == 11);
        }

        private void validarIdade(int valor)
        {
            if (valor < 18) throw new ArgumentException("Idade Inválida!!!");

        }

        public void setNome(string valor)
        {
            if (valor.Trim().Length < 3)
            {
                throw new ArgumentException("Erro 1.0");
            }
            if (valor.Any(char.IsDigit))
            {
                throw new ArgumentException("Erro 1.1");
                this.nome = valor;
            }
        }



    }
}
