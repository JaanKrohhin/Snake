using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class Difficulty
    {
        public int[] numbers = { 100, 80, 25, 1 };//speed, width, height, score multiplier
        public Difficulty(int sett)
        {
            if (sett == 1)
            {
                numbers = new int[] { 100, 80, 25, 1 };
            }
            else if (sett == 2)
            {
                numbers = new int[] { 75, 60, 20, 2 };
            }
            else if (sett == 3)
            {
                numbers = new int[] { 40, 40, 15, 3 };
            }
        }

    }
}
