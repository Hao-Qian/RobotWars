
namespace RobotWars.Navigation
{
    public class Position : IPosition
    {
        private int _xcoordinate;
        private int _ycoordinate;
        private Direction _direction;
        private int _panalties;
        public Position(int xcoordinate, int ycoordinate, Direction direction, int panalties = 0)
        {
            _xcoordinate = xcoordinate;
            _ycoordinate = ycoordinate;
            _direction = direction;
            _panalties = panalties;
        }

        public IPosition MoveForewordOnXCoordinate()
        {
            if (BoundaryChecker.IsWithinBoundary(_xcoordinate + 1))
            {
                _xcoordinate += 1;
            }
            else
            {
                _panalties++;
            }
            return new Position(_xcoordinate, _ycoordinate, _direction, _panalties);
        }

        public IPosition MoveBackwordOnXCoordinate()
        {
            if (BoundaryChecker.IsWithinBoundary(_xcoordinate - 1))
            {
                _xcoordinate -= 1;
            }
            else
            {
                 _panalties++;
            }
            return new Position(_xcoordinate, _ycoordinate, _direction, _panalties);
        }

        public IPosition MoveForewordOnYCoordinate()
        {
            if (BoundaryChecker.IsWithinBoundary(_ycoordinate + 1))
            {
                _ycoordinate += 1;
            }
            else
            {
                _panalties++;
            }
            return new Position(_xcoordinate, _ycoordinate, _direction, _panalties);
        }

        public IPosition MoveBackwordOnYCoordinate()
        {
            if (BoundaryChecker.IsWithinBoundary(_ycoordinate - 1))
            {
                _ycoordinate -= 1;
            }
            else
            {
                _panalties++;
            }
            return new Position(_xcoordinate, _ycoordinate, _direction, _panalties);
        }

        public IPosition ChangeDirectionTo(Direction direction)
        {
            _direction = direction;
            return new Position(_xcoordinate, _ycoordinate, _direction, _panalties);
        }

        public Direction GetCurrentDirection()
        {
            return _direction;
        }

        public int GetXCoordinate()
        {
            return _xcoordinate;
        }

        public int GetYCoordinate()
        {
            return _ycoordinate;
        }

        public int GetPanalties()
        {
            return _panalties;
        }
    }
}
