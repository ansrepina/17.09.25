using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сергей Есенин");
            Console.WriteLine("Живите так...");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Живите так,");
            Console.WriteLine("Как вас ведет звезда");
            Console.WriteLine("Под кущей обновленной сени");
            Console.WriteLine("С приветствием,");
            Console.WriteLine("Вас помнящий всегда");
            Console.WriteLine("Знакомый ваш - Сергей Есенин.");
            Console.ResetColor();
        }
    }
}
