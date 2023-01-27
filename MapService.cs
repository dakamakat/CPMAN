using System.Drawing;

namespace CPMAN
{
    public sealed class MapService
    {
        public char[][] Map { get; set; }

        public MapService()
        {
            Map = ReadMap();
        }
        public static char[][] ReadMap() => File.ReadAllLines(Options.filePath).Select(item => item.ToArray()).Reverse().ToArray();

        public bool WriteMap(Point currentPoint, Point previousPoint)
        {
            Map[previousPoint.X][previousPoint.Y] = Options.Empty;
            Map[currentPoint.X][currentPoint.Y] = Options.Player;
            return true;
        }

        public void ShowMap()
        {
            foreach (var item in Map)
            {
                Console.WriteLine(new string(item));
            }
        }
    }
}
