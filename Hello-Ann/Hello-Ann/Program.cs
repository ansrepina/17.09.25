using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Ann
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Ann!");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Привет, Анна!");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
