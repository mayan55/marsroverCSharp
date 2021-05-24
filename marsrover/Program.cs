using System;
using marsrover.driver;
using System.Drawing;

namespace marsrover
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mars Rover Starting.");
            Plateau plateau = new Plateau(new Point(5, 5));

  
            Driver driver = new Driver();
            driver.SetPosition(plateau, new Rover(new Point(1, 2)), "N");
            driver.Start("LMLMLMLMM");
            Console.WriteLine(driver.ActivePosition());

            driver.SetPosition(plateau, new Rover(new Point(3, 3)), "E");
            driver.Start("MMRMMRMRRM");
            Console.WriteLine(driver.ActivePosition());

        }
    }
}
