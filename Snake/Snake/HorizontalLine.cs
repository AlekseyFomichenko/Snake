using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine
    {
        List<Point> points;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            points = new List<Point>();
            for (int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                points.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in points) { p.Draw(); }
        }
    }
}
