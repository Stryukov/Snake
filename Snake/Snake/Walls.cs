using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls( int mapWidth, int mapHeight )
        {
            wallList = new List<Figure>();

            //Отрисовка рамок
            HorizontalLine upLine = new HorizontalLine(0, mapWidth-1, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth-1, mapHeight-1, '+');
            VerticalLIne leftLine = new VerticalLIne(0, 0, mapHeight - 1, '+');
            VerticalLIne RightLine = new VerticalLIne(mapWidth - 1, 0, mapHeight - 1, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(RightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
