using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение веса в фунтах:");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            if (n == 0)
            {
                Console.WriteLine("Число не должно быть равно 0");
                return;
            }

            const double gramsPerPound = 453;


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("        Фунты    |    Килограммы ");
            Console.WriteLine("--------------------------------------------------");
            for (int pounds = 1; pounds <= n; pounds++)
            {

                double totalGrams = pounds * gramsPerPound;
                double kilograms = totalGrams / 1000;

                Console.WriteLine($"{pounds,10} | {kilograms,16:F3}"); 
            }

        }
    }
}