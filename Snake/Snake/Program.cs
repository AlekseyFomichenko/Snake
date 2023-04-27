using System;
using System.Collections.Generic;
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

            Point p1 = new Point(3, 5, '*');
            p1.Draw();

            Point p2 = new Point(7, 4, '#');
            p2.Draw();
            Console.ReadLine();
        }
    }
}
