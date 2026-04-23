using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Введите значение переменной х: ");
            var x = double.Parse(Console.ReadLine());
            var y = CalculateFunction(x);
            Console.WriteLine("F(x)= " + y);        
        }
        static double CalculateFunction(double x)
        {

            double numerator = Math.Sqrt(x + 1) + Math.Sqrt(x - 1);
            double denominator = Math.Sqrt(x);

            double result = numerator / denominator;
            return result;
        }
    }
}


