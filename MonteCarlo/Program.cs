using MonteCarlo.EstimationMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarlo
{
    class Program
    {
        public static void Main(string[] args)
        {
            MonteCarloStream.Run();
            Console.ReadKey();
        }
    }
}
