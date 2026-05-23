using System;
namespace homework6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку на английском языке");
            var text = Console.ReadLine();

            Console.WriteLine("Вот что получилось: ");
            Console.WriteLine(Translate(text));
        }
        static string Translate(string s)
        {
            var result = s.ToUpper()
            .Replace("A", "4")
            .Replace("B", "8")
            .Replace("C", "(")
            .Replace("D", "|)")
            .Replace("E", "3")
            .Replace ("F", "|=")
            .Replace("G", "6")
            .Replace("H", "|-|")
            .Replace("I", "!")
            .Replace("J", ")")
            .Replace("K", "|<")
            .Replace("L", "1")
            .Replace("M", "|v|")
            .Replace("N", "|/|")
            .Replace("O", "0")
            .Replace("P", "|>")
            .Replace("Q", "9")
            .Replace("R", "|2")
            .Replace("S", "5")
            .Replace("T", "7")
            .Replace("U", "|_|")
            .Replace("V", "v")
            .Replace("W", "vv")
            .Replace("X", "><")
            .Replace("Y", "'/")
            .Replace("Z", "2")
            .Replace("  ", "   ");
            return result;

            throw new NotImplementedException();
        }
    }
}