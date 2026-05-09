using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer
{
    public abstract class SortingAlgorithm
    {
        public string Name { get; protected set; }

        // This is THE method. It runs the algorithm and records every step.
        public abstract List<SortStep> Run(int[] array);
    }
}