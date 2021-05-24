using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace marsrover.driver
{
    
    public class Rover
    {
        public Point point = new Point(0, 0);

        public Rover(Point point)
        {
            this.point = point;
        }
    }
}
