using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor colour;
        public Point()
        {
        }
        public Point(int x_, int y_, char sym_, ConsoleColor colour_)
        {
            x = x_;
            y = y_;
            sym = sym_;
            colour=colour_;
        }
        public Point(Point p, ConsoleColor colour_)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            colour = colour_;
        }
        public void Move(int offset,Directions direction)
        {
            if (direction==Directions.RIGHT)
            {
                x = x + offset;
            }
            else if (direction==Directions.LEFT)
            {
                x = x - offset;
            }
            else if (direction==Directions.UP)
            {
                y = y - offset;
            }
            else if (direction==Directions.DOWN)
            {
                y = y + offset;            }
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colour;
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
