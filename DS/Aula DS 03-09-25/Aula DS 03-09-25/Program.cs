using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aula_DS_03_09_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
            try
            {
                Funcionario marrone = new Funcionario(
                    11111111111,
                    "Marrone Passate",
                    777
                );

                Funcionario cassandra = new Funcionario(
                    11111111122,
                    "Cassandra Massorrari",
                    333
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                goto inicio;
            }


        }
    }
}
