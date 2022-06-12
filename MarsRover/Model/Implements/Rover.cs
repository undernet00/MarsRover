using System;

namespace Mars_Rover.Model
{
    public class Rover : IRover
    {
        private IMap map;
        private int currentPositionX;
        private int currentPositionY;
        private string currentOrientation;
        private char[] orders;


        public Rover(IMap map, int initialPositionX, int initialPositionY, string initialOrientation, string orders)
        {
            if (map == null) throw new ArgumentException("Map cannot be null.", nameof(map));

            if (!map.IsXWithinLimits(initialPositionX)) throw new ArgumentOutOfRangeException("InitialPositionX is out of bounds.", nameof(initialPositionX));
            if (!map.IsYWithinLimits(initialPositionY)) throw new ArgumentOutOfRangeException("InitialPositionY is out of bounds.", nameof(initialPositionY));

            if (initialOrientation == "") throw new ArgumentException("InitialOrientation cannot be empty.", nameof(initialOrientation));
            if (!map.IsValidCardinalPoint(initialOrientation)) throw new ArgumentException("InitialOrientation should only be N,S,E or W.", nameof(initialOrientation));

            if (orders == "") throw new ArgumentException("Orders cannot be empty.", nameof(orders));
            if (orders.Replace("A", "").Replace("L", "").Replace("R", "") != "") throw new ArgumentException("Orders have invalid commands.", nameof(orders));

            //TODO: ¿Do I return the last reachable position with the False in case the orders are invalid?

            this.map = map;
            this.currentPositionX = initialPositionX;
            this.currentPositionY = initialPositionY;
            this.currentOrientation = initialOrientation;
            this.orders = orders.ToCharArray();

        }

        public string ValidateOrders()
        {
            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i].ToString() == "L")
                {
                    this.currentOrientation = this.map.nextCardinalCounterClockWise(this.currentOrientation);
                }
                else if (orders[i].ToString() == "R")
                {
                    this.currentOrientation = this.map.nextCardinalClockWise(this.currentOrientation);
                }
                else if (orders[i].ToString() == "A")
                {
                    if (!this.map.IsOKToMoveForward(this.currentPositionX, this.currentPositionY, this.currentOrientation))
                    {
                        return "False, " + this.GetGPSInformation();
                    }
                    else
                    {
                        this.MoveForward();
                    }
                }
            }

            return "True, " + this.GetGPSInformation();

        }

        private void MoveForward()
        {
            switch (currentOrientation)
            {
                case "N":
                    this.currentPositionY += 1;
                    break;
                case "E":
                    this.currentPositionX += 1;
                    break;

                case "S":
                    this.currentPositionY += -1;
                    break;

                case "W":
                    this.currentPositionX += -1;
                    break;
            }

        }

        private string GetGPSInformation()
        {
            return this.currentOrientation + ", (" + this.currentPositionX + "," + this.currentPositionY + ")";
        }


    }
}
