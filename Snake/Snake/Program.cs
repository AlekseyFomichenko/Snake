using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Point p1 = new Point(3, 5, '*');
            //p1.Draw();

            //Point p2 = new Point(7, 4, '#');
            //p2.Draw();
            int x = 1;
            Func1(x);
            Console.WriteLine("Call func. x = ");

            x = 1;
            Func2(x);
            Console.WriteLine("Call func2 x = ");

            x = 1;
            Func3(x);
            Console.WriteLine("Call func3 x = ");

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y);

            p1 = new Point(1, 3, '*');
            Update(p1);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

        }
        public static void Func1(int value) { }
        public static void Func2(int value) { value++; }
        public static void Func3(int X) { X++; }
        public static void Move(Point p, int dx, int dy)
        {
            p.x += dx; p.y += dy;
        }
        public static void Update(Point p) { p = new Point(); }
    }
}
