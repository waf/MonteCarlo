namespace MonteCarlo.Shared
{
    public readonly struct MonteCarloIteration
    {
        public MonteCarloIteration(int inCircleCount, int totalCount, double piApproximation) : this()
        {
            InCircleCount = inCircleCount;
            TotalCount = totalCount;
            PiApproximation = piApproximation;
        }

        public int InCircleCount { get; }
        public int TotalCount { get; }
        public double PiApproximation { get; }
    }
}
