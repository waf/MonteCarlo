using System;
using System.Collections.Generic;

namespace MonteCarlo.Shared
{
    public static class Extensions
    {
        public static bool IsPointInsideUnitCircle(this Point point) =>
            Math.Sqrt(point.X * point.X + point.Y * point.Y) < 1;

        /// <summary>
        /// Functional "scan" operation. Similar to Aggregate, but instead of returning a
        /// single aggregated value it returns an enumerable of all the intermediate values.
        /// </summary>
        public static IEnumerable<T1> Scan<T1, T2>(this IEnumerable<T2> sequence, T1 seed, Func<T1, T2, T1> func)
        {
            if (sequence == null) throw new ArgumentNullException(nameof(sequence));
            if (func == null) throw new ArgumentNullException(nameof(func));

            var current = seed;
            foreach (var item in sequence)
            {
                current = func(current, item);
                yield return current;
            }
        }
    }
}
