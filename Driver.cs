using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace ShipmentsAssigner
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                _TestGetQuantumIndex.Run(qsim, 3).Wait();
            }
        }
    }
}