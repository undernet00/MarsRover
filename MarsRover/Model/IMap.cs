namespace Mars_Rover.Model
{
    public interface IMap
    {
        bool IsOKToMoveForward(int currentX, int currentY, string currentDirection);
        string nextCardinalClockWise(string oldCardinalPoint);
        string nextCardinalCounterClockWise(string oldCardinalPoint);

        bool IsXWithinLimits(int x);
        bool IsYWithinLimits(int y);

        bool IsValidCardinalPoint(string cardinalPoint);
    }
}