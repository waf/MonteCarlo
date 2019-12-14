using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MonteCarlo.Shared
{
    public static class Enumerables
    {
        private static readonly Random randomNumberGenerator = new Random();

        public static IEnumerable<Point> RandomPoints()
        {
            while(true)
            {
                var x = randomNumberGenerator.NextDouble();
                var y = randomNumberGenerator.NextDouble();
                yield return new Point(x, y);
            }
        }
    }
}
