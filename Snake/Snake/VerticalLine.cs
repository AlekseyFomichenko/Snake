using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine
    {
        List<Point> points;
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            points = new List<Point>();
            for (int y = yUp; x <= yDown; x++)
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
