using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLIne : Figure
    {
        public VerticalLIne (int x, int yBottom, int yTop, char sym)
        {
            pList = new List<Point>();
            for (int y = yBottom; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
