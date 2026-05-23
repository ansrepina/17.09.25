using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение e > 0):");
            double epsilon = double.Parse(Console.ReadLine());

            if (epsilon <= 0)
            {
                Console.WriteLine("Число должно быть больше 0.");
                return;
            }

            double an = 1.0; 
            double sumOfFractions = 0.0;
            int n = 0;
   

            while (Math.Abs(2.0 - an) >= epsilon)
            {
                n++; 
                sumOfFractions += 1.0 / Math.Pow(2.0, n);
                an = 1.0 + sumOfFractions;
            }

            Console.WriteLine($"Индекс первого члена последовательности , удовлетворяющий условию: {n}");
            Console.WriteLine($"Значение: {an}");
        }
    }
}
