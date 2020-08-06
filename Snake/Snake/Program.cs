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

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }


            //VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            //Draw(v1);

            //Point p = new Point(4, 5, '*');
            //Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            //Draw(fSnake);
            //Snake snake = (Snake)fSnake;

            //HorisontalLine h1 = new HorisontalLine(0, 5, 6, '&');

            //List<Figure> figures = new List<Figure>();
            //figures.Add(fSnake);
            //figures.Add(v1);
            //figures.Add(h1);

            //foreach(var f in figures)
            //{
            //    f.Draw();
            //}

            //Console.SetBufferSize(80, 25);

            //// Рамка
            //HorisontalLine UpLine = new HorisontalLine(0, 78, 0, '+');
            //HorisontalLine DownLine = new HorisontalLine(0, 78, 23, '+');
            //VerticalLine LeftLine = new VerticalLine(0, 23, 0, '+');
            //VerticalLine RightLine = new VerticalLine(0, 23, 78, '+');
            //UpLine.Drow();
            //DownLine.Drow();
            //LeftLine.Drow();
            //RightLine.Drow();

            //// Отрисовка точек
            //Point p = new Point(4, 5, '*');
            //Snake snake = new Snake(p, 4, Direction.RIGHT);
            //snake.Drow();

            //FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            //Point food = foodCreator.CreateFood();
            //food.Draw();

            //while(true)
            //{
            //    if(snake.Eat(food))
            //    {
            //        food = foodCreator.CreateFood();
            //        food.Draw();
            //    }
            //    else
            //    {
            //        snake.Move();
            //    }
            //    Thread.Sleep(100);

            //    if(Console.KeyAvailable)
            //    {
            //        ConsoleKeyInfo key = Console.ReadKey();
            //        snake.HandleKey(key.Key);
            //    }
            //}








            Console.ReadLine();
        }
    }
}
