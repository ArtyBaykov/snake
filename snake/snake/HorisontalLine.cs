﻿using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class HorisontalLine : Figure
    {
        public HorisontalLine(int xRight, int xLeft, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xRight; x <= xLeft; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
