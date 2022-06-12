using Mars_Rover.Model;
using NUnit.Framework;
using System;



namespace MarsRoverTests
{
    public class RoverTests
    {
        IMap marsMap;
        Rover rover;

        [SetUp]
        public void Setup()
        {
            marsMap = new Map(4, 4);

        }

        [Test]
        public void FromMiddleBottom()
        {
            //Arrange
            this.rover = new Rover(marsMap, 2, 0, "N", "LAA");

            //Act

            //Assert
            Assert.AreEqual("True, W, (0,0)", rover.ValidateOrders());

        }

        [Test]
        public void FromMiddleBottomOutOfMap()
        {
            //Arrange
            this.rover = new Rover(marsMap, 2, 0, "N", "LAAA");

            //Act

            //Assert
            Assert.AreEqual("False, W, (0,0)", rover.ValidateOrders());

        }

        [Test]
        public void FromMiddleTop()
        {
            //Arrange
            this.rover = new Rover(marsMap, 2, 3, "S", "AALA");

            //Act

            //Assert
            Assert.AreEqual("True, E, (3,1)", rover.ValidateOrders());

        }

        [Test]
        public void FromMiddleTopOutOfMap()
        {
            //Arrange
            this.rover = new Rover(marsMap, 2, 3, "S", "AALAA");

            //Act

            //Assert
            Assert.AreEqual("False, E, (3,1)", rover.ValidateOrders());

        }

        [Test]
        public void LongDiagonalTraverse()
        {
            //Arrange
            this.rover = new Rover(marsMap, 0, 0, "E", "ALARALARALA");


            //Act

            //Assert
            Assert.AreEqual("True, N, (3,3)", rover.ValidateOrders());

        }

        [Test]
        public void LongDiagonalTraverseOutOfMap()
        {
            //Arrange
            this.rover = new Rover(marsMap, 0, 0, "E", "ALARALARALAAR");


            //Act

            //Assert
            Assert.AreEqual("False, N, (3,3)", rover.ValidateOrders());

        }

        [Test]
        public void ContructorArgumentMap()
        {
            //Arrange



            //Act

            //Assert
            Assert.Throws<ArgumentException>(delegate { this.rover = new Rover(null, 0, 0, "E", "ALARALARALAAR"); });
        }

        [Test]
        public void ContructorArgumentInitialOrientationEmpty()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>(delegate { this.rover = new Rover(marsMap, 0, 0, "", "ALARALARALAAR"); });
        }

        [Test]
        public void ContructorArgumentInitialOrientationValidCardinal1()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>(delegate { this.rover = new Rover(marsMap, 0, 0, "A", "ALARALARALAAR"); });

        }

        [Test]
        public void ContructorArgumentInitialOrientationValidCardinal2()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>(delegate { this.rover = new Rover(marsMap, 0, 0, "SADARasd", "ALARALARALAAR"); });
        }

        [Test]
        public void ConstructorArgumentInitialPositionX1()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(delegate { this.rover = new Rover(marsMap, -1, 0, "N", "L"); });
        }

        [Test]
        public void ConstructorArgumentInitialPositionX2()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(delegate { this.rover = new Rover(marsMap, 100, 0, "N", "L"); });
        }
        [Test]
        public void ConstructorArgumentInitialPositionY1()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(delegate { this.rover = new Rover(marsMap, 0, 4, "N", "L"); });
        }

        [Test]
        public void ConstructorArgumentInitialPositionY2()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(delegate { this.rover = new Rover(marsMap, 0, 100, "N", "L"); });
        }

        [Test]
        public void ConstructorArgumentOrders1()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>(delegate { this.rover = new Rover(marsMap, 0, 0, "N", "ATA"); });
        }

        [Test]
        public void ConstructorArgumentOrders2()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>(delegate { this.rover = new Rover(marsMap, 0, 0, "N", ".LA"); });
        }

    }
}
