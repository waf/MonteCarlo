using MonteCarlo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonteCarlo.EstimationMethods
{
    static class MonteCarloStream
    {
        public static void Run()
        {
            IEnumerable<MonteCarloIteration> stream = Enumerables
                .RandomPoints()
                .Scan(
                    seed: new MonteCarloIteration(),
                    func: NextIteration
                );

            while(true)
            {
                stream = stream.Skip(1_000_000);
                Console.WriteLine(stream.First().PiApproximation);
            }
        }

        private static MonteCarloIteration NextIteration(MonteCarloIteration previous, Point point)
        {
            int inCircleCount = point.IsPointInsideUnitCircle()
                ? previous.InCircleCount + 1
                : previous.InCircleCount;
            var totalCount = previous.TotalCount + 1;

            return new MonteCarloIteration(inCircleCount, totalCount,
                piApproximation: 4.0 * inCircleCount / totalCount
            );
        }
    }
}
