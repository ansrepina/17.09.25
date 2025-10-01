using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = 2.5; //обязательно пишем через точку, а не запятую  
            //Console.WriteLine("x = " + x);

            //int n = (int)x;
            //Console.WriteLine("x = " + n);

            //x = double.Parse(Console.ReadLine());
            //Console.WriteLine("x = " + x);
        
            var x = InputInteger("Введите 1 координату");
            var y = InputInteger("Введите 2 координату");

            Console.WriteLine("Точка (" + x + ", " + y + ")");
        }
        static int InputInteger(string message) 
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
