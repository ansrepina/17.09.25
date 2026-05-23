using System;
namespace homework8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите абсциссу точки");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату точки");
            var y = double.Parse(Console.ReadLine());

            if (IsInArea(x, y))
                Console.WriteLine("Точка лежит в обозначенной области");
            else 
                Console.WriteLine("Точка не лежит в обозначенной области");
        }

        static bool IsInArea(double x, double y) =>
            -0.5 <= y && y <= 2 && -1 <= x && x <= 1.5;
    }
}