using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclid;

namespace EuclidConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Point(1, 2.5);
            Console.WriteLine(p.GetInfo());

            var s = new Segment(new Point(1, 1), new Point(-1, 3));
            Console.WriteLine(s.GetInfo());
            Console.WriteLine($"длина отрезка {s.Length:F3}");

            try
            {
                s = Geometry.CreateSegment(new Point(5, -1), new Point(0, 0));
                Console.WriteLine(s.GetInfo());

                s = Geometry.CreateSegment(new Point(5, 5), new Point(5, 5));
                Console.WriteLine(s.GetInfo());
            } 
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
