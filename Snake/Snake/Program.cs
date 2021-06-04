using System;
using System.Net.Http.Headers;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4, 5,'#');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(4, 7, 7, '-');
            hLine.Draw();

            VerticalLIne vLine = new VerticalLIne(8, 3, 8, '|');
            vLine.Draw();

            Console.ReadLine();
        }

    }
}
