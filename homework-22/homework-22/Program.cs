using System;

public class PyramidCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длину стороны основания: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите высоту пирамиды: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double S = (a * a * Math.Sqrt(3)) / 4;
        double V = (a * a * Math.Sqrt(3) * h) / 12;

        Console.WriteLine($"Объем пирамиды: {V}");
        Console.WriteLine($"Площадь основания: {S}");
    }
}