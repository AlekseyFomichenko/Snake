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

            int x1 = 3, y1 = 4;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 7, y2 = 8;
            char sym2 = '#';
            Draw(x2, y2, sym2);

            Console.WriteLine();
            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
