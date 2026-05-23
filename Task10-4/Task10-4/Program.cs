using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var n = int.Parse(Console.ReadLine()); 

            int remainder;
            int count = 0;

            while (n > 0) 
            {
                int res = Math.DivRem(n, 2, out remainder); 
                if (remainder == 0) 
                {
                    count++; 
                }
                n = res; 
            }
            Console.WriteLine($"Количество нулей в двоичной записи числа: {count}");
        }
    }
}