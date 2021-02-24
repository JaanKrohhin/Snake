using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;
        ConsoleColor colour;
        Random random = new Random();
        public FoodCreator(int mapWidht,int mapHeight,char sym, ConsoleColor colour)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
            this.colour = colour;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym, colour);
        }
    }
}
