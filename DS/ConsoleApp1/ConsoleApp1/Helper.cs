using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Helper
    {
        public static string input(string msg = "")
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        public static void output(string msg = "")
        {
            Console.WriteLine(msg);
        }
        public static string valorGlobal;
    }
}
