using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Отрисовка рамочки
            //HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            //VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            //upLine.Draw();
            //downLine.Draw();
            //leftLine.Draw();
            //rightLine.Draw();

            //VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            //Draw(v1);
                        
            //Отрисовка точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            //Draw(fSnake);
            //Snake snake = (Snake)fSnake;

            //HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            //List<Figure> figures = new List<Figure>();
            //figures.Add(fSnake);
            //figures.Add(v1);
            //figures.Add(h1);

            //foreach (var f in figures)
            //{
            //    f.Draw();
            //}


            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
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

            
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
