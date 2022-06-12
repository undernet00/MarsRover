using NUnit.Framework;
using Mars_Rover.Model;
using System;

namespace MarsRoverTests
{
    public class MapTests
    {
        //Tests a square map
        Map marsMap;

        [SetUp]
        public void Setup()
        {
            marsMap = new Map(4, 4);

        }

        [Test]
        public void LowerLeftCornerNorth()
        {
            //Arrange
            int currentX = 0;
            int currentY = 0;
            string currentOrientation = "N";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));
        }

        [Test]
        public void LowerLeftCornerWest()
        {
            //Arrange
            int currentX = 0;
            int currentY = 0;
            string currentOrientation = "W";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));
        }

        [Test]
        public void LowerLeftCornerSouth()
        {
            //Arrange
            int currentX = 0;
            int currentY = 0;
            string currentOrientation = "S";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));
        }
        [Test]
        public void LowerLeftCornerEast()
        {
            //Arrange
            int currentX = 0;
            int currentY = 0;
            string currentOrientation = "E";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void UpperLeftCornerNorth()
        {
            //Arrange
            int currentX = 0;
            int currentY = 3;
            string currentOrientation = "N";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }
        [Test]
        public void UpperLeftCornerWest()
        {
            //Arrange
            int currentX = 0;
            int currentY = 3;
            string currentOrientation = "W";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void UpperLeftCornerSouth()
        {
            //Arrange
            int currentX = 0;
            int currentY = 3;
            string currentOrientation = "S";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void UpperLeftCornerEast()
        {
            //Arrange
            int currentX = 0;
            int currentY = 3;
            string currentOrientation = "E";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void UpperRightCornerNorth()
        {
            //Arrange
            int currentX = 3;
            int currentY = 3;
            string currentOrientation = "N";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }
        [Test]
        public void UpperRightCornerWest()
        {
            //Arrange
            int currentX = 3;
            int currentY = 3;
            string currentOrientation = "W";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void UpperRightCornerSouth()
        {
            //Arrange
            int currentX = 3;
            int currentY = 3;
            string currentOrientation = "S";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void UpperRightCornerEast()
        {
            //Arrange
            int currentX = 3;
            int currentY = 3;
            string currentOrientation = "E";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }
        [Test]
        public void LowerRightCornerNorth()
        {
            //Arrange
            int currentX = 3;
            int currentY = 0;
            string currentOrientation = "N";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }
        [Test]
        public void LowerRightCornerWest()
        {
            //Arrange
            int currentX = 3;
            int currentY = 0;
            string currentOrientation = "W";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void LowerRightCornerSouth()
        {
            //Arrange
            int currentX = 3;
            int currentY = 0;
            string currentOrientation = "S";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void LowerRightCornerEast()
        {
            //Arrange
            int currentX = 3;
            int currentY = 0;
            string currentOrientation = "E";

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void MiddleToWest()
        {
            //Arrange
            int currentX = 2;
            int currentY = 2;
            string currentOrientation = "W";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void MiddleToNorth()
        {
            //Arrange
            int currentX = 2;
            int currentY = 2;
            string currentOrientation = "N";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }

        [Test]
        public void MiddleToEast()
        {
            //Arrange
            int currentX = 2;
            int currentY = 2;
            string currentOrientation = "E";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }
        [Test]
        public void MiddleToSouth()
        {
            //Arrange
            int currentX = 2;
            int currentY = 2;
            string currentOrientation = "S";

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsOKToMoveForward(currentX, currentY, currentOrientation));

        }
        [Test]
        public void IsXWithinLimitsLow1()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsXWithinLimits(-1));

        }

        [Test]
        public void IsXWithinLimitsLow2()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsXWithinLimits(-100));

        }

        [Test]
        public void IsXWithinLimitsLow3()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsXWithinLimits(0));

        }

        [Test]
        public void IsXWithinLimitsHigh1()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsXWithinLimits(4));

        }

        [Test]
        public void IsXWithinLimitsHigh2()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsXWithinLimits(100));

        }

        [Test]
        public void IsXWithinLimitsHigh3()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsXWithinLimits(3));

        }

        [Test]
        public void IsYWithinLimitsLow1()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsYWithinLimits(-1));

        }

        [Test]
        public void IsYWithinLimitsLow2()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsYWithinLimits(-100));

        }

        [Test]
        public void IsYWithinLimitsHigh1()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsYWithinLimits(4));

        }

        [Test]
        public void IsYWithinLimitsHigh2()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsFalse(marsMap.IsYWithinLimits(100));

        }
        [Test]
        public void IsYWithinLimitsHigh3()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsTrue(marsMap.IsYWithinLimits(3));

        }
        [Test]
        public void IsItOKToMoveForwardArgumentCurrentDirectionWrongCardinalPoint()
        {
            //Arrange

            //Act

            //Assert

            Assert.Throws<ArgumentException>(delegate { bool result = marsMap.IsOKToMoveForward(0, 0, "A"); });
        }

        [Test]
        public void IsItOKToMoveForwardCardinalPointTooLong()
        {
            //Arrange

            //Act

            //Assert

            Assert.Throws<ArgumentException>(delegate { bool result = marsMap.IsOKToMoveForward(0, 0, "AASD"); });
        }
    }

}