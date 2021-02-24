using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class HorizontalLine:Figure
    {
        public HorizontalLine(int xleft,int xright,int y, char sym, ConsoleColor colour)
        {
            plist = new List<Point>();
            for (int x = xleft; x < xright; x++)
            {
                Point p = new Point(x, y, sym, colour);
                plist.Add(p);

            }
        }
    }
}
 