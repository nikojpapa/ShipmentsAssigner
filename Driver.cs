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
                // _TestXIfQubitEqualToInt.Run(qsim, 4).Wait();
                // _TestGetQuantumIndex.Run(qsim, 3).Wait();
                // _TestLoadStop.Run(qsim).Wait();
                _TestOracle.Run(qsim, 4).Wait();
            }
        }
    }
}