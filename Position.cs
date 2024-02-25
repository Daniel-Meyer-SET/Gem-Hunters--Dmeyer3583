using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gem_Hunters__Dmeyer3583
{
    internal class Position
    {
        int x, y;
        // set get x and y 
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public  Position(int y, int x) { 
            this.Y = y; 
            this.X = x;
            
        }
    }
}
