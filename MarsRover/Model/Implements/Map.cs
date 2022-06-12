using System;

namespace Mars_Rover.Model
{
    public class Map : IMap
    {
        private int[,] field;

        public Map(int squareWidth, int squareHeight)
        {
            this.field = new int[squareWidth, squareHeight];
        }

        public bool IsOKToMoveForward(int currentX, int currentY, string currentDirection)
        {
            if (!this.IsValidCardinalPoint(currentDirection)) throw new ArgumentException("CurrentDirection should only be N,S,E or W.", nameof(currentDirection));
                    
            switch (currentDirection)
            {
                case "N":
                    if (currentY + 1 > field.GetUpperBound(1)) return false;
                    break;
                case "W":
                    if (currentX - 1 < 0) return false;
                    break;
                case "S":
                    if (currentY - 1 < 0) return false;
                    break;
                case "E":
                    if (currentX + 1 > field.GetUpperBound(0)) return false;
                    break;
            }

            return true;
        }

        public bool IsXWithinLimits(int x)
        {
            return (x >= 0 && x <= field.GetUpperBound(0));
        }

        public bool IsYWithinLimits(int y)
        {
            return (y >= 0 && y <= field.GetUpperBound(1));
        }

        public string nextCardinalClockWise(string oldCardinalPoint)
        {
            if (!this.IsValidCardinalPoint(oldCardinalPoint)) throw new ArgumentException("CurrentDirection should only be N,S,E or W.", nameof(oldCardinalPoint));

            switch (oldCardinalPoint)
            {
                case "N":
                    return "E";

                case "E":
                    return "S";

                case "S":
                    return "W";

                case "W":
                    return "N";
            }

            return "";
        }

        public string nextCardinalCounterClockWise(string oldCardinalPoint)
        {
            if (!this.IsValidCardinalPoint(oldCardinalPoint)) throw new ArgumentException("CurrentDirection should only be N,S,E or W.", nameof(oldCardinalPoint));

            switch (oldCardinalPoint)
            {
                case "N":
                    return "W";

                case "W":
                    return "S";

                case "S":
                    return "E";

                case "E":
                    return "N";
            }

            return "";
        }

        public bool IsValidCardinalPoint(string cardinalPoint)
        {
            return (cardinalPoint == "N" || cardinalPoint == "S" || cardinalPoint == "E" || cardinalPoint == "W");
        }


    }
}
