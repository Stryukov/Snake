using System;
using System.Net.Http.Headers;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize( 80, 25);
            Console.SetBufferSize( 80, 25);
            HorizontalLine upLine = new HorizontalLine( 0, 78, 0, '+' );
            HorizontalLine downLine = new HorizontalLine( 0, 78, 24, '+');
            VerticalLIne leftLine = new VerticalLIne( 0, 0, 24, '+');
            VerticalLIne rightLine = new VerticalLIne( 78, 0, 24, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }

    }
}
