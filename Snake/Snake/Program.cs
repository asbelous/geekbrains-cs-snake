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

            //Отрисовка рамочки

            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            topLine.Drow();
            bottomLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрисовка точки

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }
    }
}
