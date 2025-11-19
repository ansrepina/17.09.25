using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            var n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                sum += double.Parse(Console.ReadLine());
            }
            double result = sum/n;
            Console.WriteLine($"Среднее арифметическое чисел = {result}");
        
        }
    }
}
