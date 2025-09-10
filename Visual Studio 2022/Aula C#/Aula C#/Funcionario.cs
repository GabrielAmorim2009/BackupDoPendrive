using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms; serve para burlar o sistema e fazer com que ele deixe usar componentes graficos na classe

namespace Aula_C_
{
    internal class Funcionario
    {
        public int id;
        public string nome;
        public string cargo;
        public double salario = 0;

        public void verDados()
        {
            MessageBox.Show(
                $"ID: {this.id}\n" +
                $"Nome: {this.nome}\n" +
                $"Cargo: {this.cargo}\n" +
                $"Salario: R${this.salario.ToString("F2")}"
            );
        }

        //this => quero esse objeto

    }
}
