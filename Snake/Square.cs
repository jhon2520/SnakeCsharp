using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Square
    {
        public int x, y, x_old, y_old;

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.x_old = x;
            this.y_old = y;
        }
    }
}
