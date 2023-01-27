namespace CPMAN
{
    public struct Point
    {
        private int x;
        private int y;
        public int X
        {
            get => x;
            set
            {
                if (value <= 0)
                    x = 0;
                else
                {
                    x = value;
                }
            }
        }

        public int Y
        {
            get => y;
            set
            {
                if (value <= 0)
                    y = 0;
                else
                {
                    y = value;
                }
            }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
