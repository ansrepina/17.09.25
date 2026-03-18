using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    public static class Geometry
    {
        public static Segment CreateSegment(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
                throw new ArgumentException($"Концы отрезка не должны совпадать: {a.GetInfo()}");
            return new Segment(a, b);
        }

        public static bool IsSegmentContainsPoint(Segment s, Point p) => s.IsContains(p);
    }
}
