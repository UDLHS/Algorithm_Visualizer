using System.Collections.Generic;

namespace AlgorithmVisualizer
{
    public class PathfindingStep
    {
        // Newly visited nodes this step
        public List<(int row, int col)> NewlyVisited { get; set; } = new List<(int, int)>();

        // Final path (only set on last step)
        public List<(int row, int col)> FinalPath { get; set; } = new List<(int, int)>();

        // Is this the final step?
        public bool IsComplete { get; set; } = false;
    }
}