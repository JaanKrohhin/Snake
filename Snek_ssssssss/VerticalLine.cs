using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class VerticalLine:Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym, ConsoleColor colour)
        {
            plist = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            {
                Point p = new Point(x, y, sym, colour);
                plist.Add(p);
            }
        }
    }
}
