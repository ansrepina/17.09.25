using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    public class Segment //segment - отрезок. Состоит из 2-х точек (Point). 
    {
        public Point A; //Point - тип. Как int, но с другими качествами
        public Point B;

        public double Length //Свойство Только для чтения = get пишем, а set - нет. => ничего не присваиваем
        {
            get
            {
                var dx = A.X - B.X;
                var dy = A.Y - B.Y;

                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public Segment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public string GetInfo() => $"отрезок с концами в точках {A.GetInfo()} и {B.GetInfo()}";

        public bool IsContains(Point p)
        {
            var apX = p.X - A.X;
            var apY = p.Y - A.Y;
            var pbX = B.X - p.X;
            var pbY = B.Y - p.Y;
            return Math.Abs(apX * pbY - apY * pbX) < 1e-13 && Math.Abs(apX * pbX + apY * pbY) > 1e-13;
        }
    }
}
