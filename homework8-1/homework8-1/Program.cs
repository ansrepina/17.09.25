using System;

namespace homework8_1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число k");
            var k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число m");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (AreSameParity(k, m, n))
                Console.WriteLine("k, m, n - числа одинаковой четности");
            else 
                Console.WriteLine("k, m, n не являются числами одинаковой четности");
        }

        static bool AreSameParity(int k, int m, int n) =>
            (k % 2 == m % 2) && (m % 2 == n % 2);
    }
}
