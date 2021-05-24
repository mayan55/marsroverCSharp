using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using marsrover.driver;

namespace marsrover.driver
{
    
    public class Plateau
    {
        public Point start = new Point(0,0);
        public Point end = new Point();

        public Plateau(Point point)
        {
            end = point;
        }

        public bool PointCheck(Point point)
        {

            if (start.X <= point.X && point.X <= end.X && start.Y <= point.Y && point.Y <= end.Y)
            {
                return true;
            }
            return false;
        }

    }
}
