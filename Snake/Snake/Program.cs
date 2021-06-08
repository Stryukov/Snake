using System;
using System.Net.Http.Headers;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();


            /*HorizontalLine hLine = new HorizontalLine(4, 7, 7, '-');
            hLine.Draw();

            VerticalLIne vLine = new VerticalLIne(8, 3, 8, '|');
            vLine.Draw();*/

            Console.ReadLine();
        }

    }
}
