using System;

static void Main(string[] args)
{ 
Console.WriteLine("Введите длину стороны основания: ");
var a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите высоту пирамиды: ");
var h = Convert.ToDouble(Console.ReadLine());

var S = (a * a * Math.Sqrt(3)) / 4;
var V = (a * a * Math.Sqrt(3) * h) / 12;

Console.WriteLine("Объем пирамиды: { V}");
Console.WriteLine("Площадь поверхности: { S}");
}
