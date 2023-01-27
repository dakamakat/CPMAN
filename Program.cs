namespace CPMAN
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MapService mapReader = new();
            Mover mover = new(mapReader);
            mapReader.ShowMap();
            while (true)
            {
                mover.WaitForInput();
            }
        }
    }
}