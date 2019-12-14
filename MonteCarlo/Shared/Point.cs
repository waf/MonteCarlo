namespace MonteCarlo.Shared
{
    public readonly struct Point
    {
        public Point(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }
    }
}
