using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class HorizontalLine:Figure
    {
        public HorizontalLine(int xleft,int xright,int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xleft; x < xright; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);

            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Point p in plist)
            {
                p.Draw();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
 