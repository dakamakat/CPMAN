namespace CPMAN
{
    public sealed class Mover
    {
        public Point _currentPoint { get; set; }

        private MapService _mapService;
        private Point _bounds;

        public Mover(MapService mapService)
        {
            ArgumentNullException.ThrowIfNull(mapService);
            _mapService = mapService;
            _currentPoint = new Point(1, 1);
            _bounds = new Point(_mapService.Map[0].Length, _mapService.Map.Length);
        }


        public void WaitForInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Point _current = _currentPoint;
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    Move(new Point(_current.X, _current.Y + 1));
                    break;
                case ConsoleKey.A:
                    Move(new Point(_current.X - 1, _current.Y));
                    break;
                case ConsoleKey.S:
                    Move(new Point(_current.X, _current.Y - 1));
                    break;
                case ConsoleKey.D:
                    Move(new Point(_current.X + 1, _current.Y));
                    break;
                default:
                    break;
            }
        }

        private bool Move(Point nextPoint)
        {
            if (IsInBounds(nextPoint))
            {
                bool result = _mapService.WriteMap(nextPoint, _currentPoint);
                if (result)
                    _currentPoint = nextPoint;
            }
            return false;
        }

        private bool IsInBounds(Point move) => move.X < _bounds.X && move.Y < _bounds.Y && _mapService.Map[move.X][move.Y] != Options.Wall;
    }
}
