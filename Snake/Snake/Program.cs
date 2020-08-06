using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(7, 7, '/');
            p3.Draw();

            Point p4 = new Point(10, 9, '+');
            p4.Draw();

            HorisontalLine line = new HorisontalLine(5, 10, 10, '+');
            line.Drow();












            Console.ReadLine();
        }
    }
}
