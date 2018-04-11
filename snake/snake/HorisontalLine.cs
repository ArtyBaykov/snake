using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class HorisontalLine
    {
        List<Point> pList;

        public HorisontalLine(int xRight, int xLeft, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xRight; x <= xLeft; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
