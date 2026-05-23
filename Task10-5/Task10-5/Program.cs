using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Введите годовую процентную ставку: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите начальную сумму: ");
            double m = double.Parse(Console.ReadLine());

            Console.Write("Введите пороговое значение k для ежемесячного увеличения: ");
            double k = double.Parse(Console.ReadLine());

            if (x <= 0 || m <= 0 || k <= 0)
            {
                Console.WriteLine("Все введенные значения (x, m, k) должны быть положительными.");
                return;
            }

            double monthlyRate = (x / 100.0) / 12.0;

            double currentDeposit = m;
            int month = 0;
            double monthlyIncrease = 0.0;

            while (monthlyIncrease <= k)
            {
                month++;
                monthlyIncrease = currentDeposit * monthlyRate;
                currentDeposit += monthlyIncrease;

                //Console.WriteLine($"Месяц {month}: Прирост = {monthlyIncrease:F2} руб., Вклад = {currentDeposit:F2} руб.");

                if (monthlyIncrease > k)
                {
                    Console.WriteLine($"\nНа {month}-м месяце ежемесячное увеличение вклада ({monthlyIncrease:F2} руб.) впервые превысило {k:F2} руб.");
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}

