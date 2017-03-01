
namespace RobotWars.Navigation
{
    public static class BoundaryChecker
    {
        private const int MaxBoundaryValue = 4;
        private const int MinBoundaryValue = 0;

        public static bool IsWithinBoundary(int nextPosition)
        {
            return nextPosition >= MinBoundaryValue && nextPosition <= MaxBoundaryValue;
        }
    }
} 
