using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение аргумента");
        var x = double.Parse(Console.ReadLine());
        Console.WriteLine($"f({x:F2}) = {F(x):F2}");
    }
    static double F(double x)
    {
        if (x < -4)
            return 46;
        else if (x <= 2)
            return 3 * x * x - 2;
        else
            return 10;
    }
}
