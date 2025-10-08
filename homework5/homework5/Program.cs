using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate(2, 3) + Calculate(3, 7) + Calculate(5, 5);
            Console.WriteLine(Math.Round(x, 3));
        }

        static double Calculate(double a, double b) =>
            Math.Sqrt(a + Math.Log(1 + Math.Sqrt(b)));
    }
}
