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

            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            int w = numList[3];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> symList = new List<char>();
            symList.Add('*');
            symList.Add('#');
            symList.Add('/');
            symList.Add('+');

            foreach(int i in symList)
            {
                Console.WriteLine(i);
            }












            Console.ReadLine();
        }
    }
}
