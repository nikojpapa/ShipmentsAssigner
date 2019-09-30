using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Utils.Compare;

namespace ShipmentsAssigner
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var bitAccuracy = 3;
                var maxError = 0.25;
                if (args.Length > 0) {
                    Int32.TryParse(args[0], out bitAccuracy);
                }
                if (args.Length > 1) {
                    Double.TryParse(args[1], out maxError);
                }
                
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // _TestXIfQubitEqualToInt.Run(qsim, 4).Wait();
                // _TestGetQuantumIndex.Run(qsim, 3).Wait();
                // _TestLoadStop.Run(qsim).Wait();
                // _TestOracle.Run(qsim, 4).Wait();
                // _TestOracleAugmented.Run(qsim, 4).Wait();
                // _TestApplyOracle.Run(qsim).Wait();
                _TestCountSolutions.Run(qsim, bitAccuracy, maxError).Wait(-1);

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                var seconds = elapsedMs / 1000;
                System.Console.WriteLine($"{seconds / 60} minutes {seconds % 60} seconds");
            }
        }
    }
}