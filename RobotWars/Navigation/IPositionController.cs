
namespace RobotWars.Navigation
{
    public interface IPositionController
    {
        IPosition Move();

        IPosition TurnLeft();

        IPosition TurnRight();
    }
}
