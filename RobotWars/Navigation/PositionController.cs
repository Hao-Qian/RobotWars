
namespace RobotWars.Navigation
{
    public class PositionController: IPositionController
    {
        private IPosition _position;

        public PositionController(IPosition position)
        {
            _position = position;
        }

        public IPosition Move()
        {
                var currentDirection = _position.GetCurrentDirection();
                if (currentDirection.Equals(Direction.East))
                {
                    _position = _position.MoveForewordOnXCoordinate();
                }
                if (currentDirection.Equals(Direction.West))
                {
                    _position = _position.MoveBackwordOnXCoordinate();
                }
                if (currentDirection.Equals(Direction.North))
                {
                   _position = _position.MoveForewordOnYCoordinate();
                }
                if (currentDirection.Equals(Direction.South))
                {
                    _position = _position.MoveBackwordOnYCoordinate();
                }
            return _position;
        }

        public IPosition TurnLeft()
        {
            var currentDirection = _position.GetCurrentDirection();
            if (currentDirection == Direction.East)
            {
                _position = _position.ChangeDirectionTo(Direction.North);
            }
            if (currentDirection == Direction.North)
            {
                _position = _position.ChangeDirectionTo(Direction.West);
            }
            if (currentDirection == Direction.West)
            {
                _position = _position.ChangeDirectionTo(Direction.South);
            }
            if (currentDirection == Direction.South)
            {
                _position = _position.ChangeDirectionTo(Direction.East);
            }
            return _position;
        }

        public IPosition TurnRight()
        {
            var currentDirection = _position.GetCurrentDirection();
            if (currentDirection == Direction.East)
            {
                _position = _position.ChangeDirectionTo(Direction.South);
            }
            if (currentDirection == Direction.South)
            {
                _position = _position.ChangeDirectionTo(Direction.West);
            }
            if (currentDirection == Direction.West)
            {
                _position = _position.ChangeDirectionTo(Direction.North);
            } 
            if (currentDirection == Direction.North)
            {
                _position = _position.ChangeDirectionTo(Direction.East);
            }
            return _position;
        }
    }
}
