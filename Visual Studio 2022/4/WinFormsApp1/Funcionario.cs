using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Funcionario
    {
        public int id;
        public string nome;
        public string cargo;
        public double salario;

        public void verDados() 
        {
            MessageBox.Show(
                $"ID: {this.id}\n" +
                $"Nome: {this.nome}\n" +
                $"Cargo: {this.cargo} \n" +
                $"Salário: {this.salario}"
            );
        }
        
    }
}
