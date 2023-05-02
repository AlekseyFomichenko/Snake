using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                points.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);
            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && direction != Direction.Right)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow && direction != Direction.Left)
                direction = Direction.Right;
            else if (key == ConsoleKey.DownArrow && direction != Direction.Up)
                direction = Direction.Down;
            else if (key == ConsoleKey.UpArrow && direction != Direction.Down)
                direction = Direction.Up;
        }
    }
}
