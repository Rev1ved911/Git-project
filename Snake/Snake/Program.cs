using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // Рамка
            HorisontalLine UpLine = new HorisontalLine(0, 78, 0, '+');
            HorisontalLine DownLine = new HorisontalLine(0, 78, 23, '+');
            VerticalLine LeftLine = new VerticalLine(0, 23, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, 23, 78, '+');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(50);
                snake.Move();
            }








            Console.ReadLine();
        }
    }
}
