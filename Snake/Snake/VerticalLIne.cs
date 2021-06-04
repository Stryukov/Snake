using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLIne
    {
        List<Point> pList;

        public VerticalLIne (int x, int yBottom, int yTop, char sym)
        {
            pList = new List<Point>();
            for (int y = yBottom; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
