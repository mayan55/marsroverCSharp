using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using marsrover.driver;

namespace MarsroverTest
{
    [TestClass]
    public class DriverTest
    {
        Plateau plateau = new Plateau(new Point(5, 5));
        Driver driver = new Driver();

        [TestMethod]
        public void Rover_1Test()
        {
            
            driver.SetPosition(plateau, new Rover(new Point(1, 2)), "N");
            driver.Start("LMLMLMLMM");
            Assert.AreEqual(new Point(1, 3), driver.rover.point);
            Assert.AreEqual("N", driver.direction);
   
        }

        [TestMethod]
        public void Rover_2Test()
        {

            driver.SetPosition(plateau, new Rover(new Point(3, 3)), "E");
            driver.Start("MMRMMRMRRM");
            Assert.AreEqual(new Point(5, 1), driver.rover.point);
            Assert.AreEqual("E", driver.direction);

        }

        [TestMethod]
        public void PlateauPointCheckTest()
        {
            Assert.IsFalse(plateau.PointCheck(new Point(5, 6)));
            Assert.IsTrue(plateau.PointCheck(new Point(5, 5)));
        }
    }
}
