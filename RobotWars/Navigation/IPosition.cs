
namespace RobotWars.Navigation
{
    public interface IPosition
    {
        IPosition MoveForewordOnXCoordinate();

        IPosition MoveBackwordOnXCoordinate();

        IPosition MoveForewordOnYCoordinate();

        IPosition MoveBackwordOnYCoordinate();

        IPosition ChangeDirectionTo(Direction direction);

        Direction GetCurrentDirection();

        int GetXCoordinate();

        int GetYCoordinate();

        int GetPanalties();
    }
}
