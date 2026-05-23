using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длину стороны основания: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите высоту пирамиды: ");
        double h = Convert.ToDouble(Console.ReadLine());


        double V = (a * a * Math.Sqrt(3) * h) / 12;

        double baseArea = (a * a * Math.Sqrt(3)) / 4;
        double apothem = Math.Sqrt(h * h + (a / 2) * (a / 2));
        double sideArea = 0.5 * a * apothem;
        double lateralArea = 3 * sideArea;
        double surfaceArea = baseArea + lateralArea;

        Console.WriteLine($"Объем пирамиды: {V}");
        Console.WriteLine($"Площадь поверхности пирамиды: {surfaceArea}");

    }
}
