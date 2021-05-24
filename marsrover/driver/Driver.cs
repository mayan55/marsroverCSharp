using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace marsrover.driver
{
    public class Driver
    {
        public string direction = "";
        protected static string[] directions = { "N", "E", "S", "W" };
        protected Plateau plateau = null;
        public Rover rover = new Rover(new Point(0, 0));

        public void SetPosition(Plateau plateau, Rover rover, string direction = "N")
        {
            this.direction = direction;
            this.rover.point = rover.point;
            this.plateau = plateau;
        }

        private int DirectionIndex(string direction)
        {
            return Array.IndexOf(directions, direction);
        }

        public void Start(string commands)
        {
            foreach (var item in commands)
            {
                this.Run(item.ToString());
            }
        }

        private void Run(string item)
        {
            if (item == "L")
            {
                this.Left();
            }
            else if (item == "R")
            {
                this.Right();
            }
            else if (item == "M")
            {
                this.Move();
            }
        }

        private void Left()
        {
            if (this.direction == "N")
            {
                this.direction = "W";
            }
            else
            {
                this.direction = directions[this.DirectionIndex(this.direction) - 1];
            }

        }

        private void Right()
        {
            if (this.direction == "W")
            {
                this.direction = "N";
            }
            else
            {
                this.direction = directions[this.DirectionIndex(this.direction) + 1];
            }

        }

        private bool Move()
        {
            if (!this.plateau.PointCheck(this.rover.point))
            {
                return false;
            }

            if (this.direction == "N")
            {
                this.rover.point.Y += 1;

            }
            else if (this.direction == "S")
            {
                this.rover.point.Y -= 1;

            }
            else if (this.direction == "E")
            {
                this.rover.point.X += 1;

            }
            else if (this.direction == "W")
            {
                this.rover.point.X -= 1;
            }

            return true;

        }

        public string ActivePosition()
        {
            return this.rover.point.X + " " + this.rover.point.Y + " " + this.direction;
        }
    }
}
