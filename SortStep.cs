using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer
{
    // What state is each bar in?
    public enum BarState
    {
        Default,    // Normal gray/blue
        Comparing,  // Being compared right now (yellow)
        Swapping,   // Being swapped right now (red)
        Sorted      // In final position (green)
    }

    public class SortStep
    {
        // Snapshot of the array at this moment
        public int[] Array { get; set; }

        // Which indices are being compared?
        public int[] ComparingIndices { get; set; }

        // Which indices are being swapped?
        public int[] SwappingIndices { get; set; }

        // Which indices are already sorted?
        public int[] SortedIndices { get; set; }

        // How many comparisons so far?
        public int ComparisonCount { get; set; }
    }
}
