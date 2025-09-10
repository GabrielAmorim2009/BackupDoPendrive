using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Helper2
    {
        public string input(string msg = "")
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        public void output(string msg = "")
        {
            Console.WriteLine(msg);
        }
    }
}
