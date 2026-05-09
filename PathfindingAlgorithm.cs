using System.Collections.Generic;

namespace AlgorithmVisualizer
{
    public abstract class PathfindingAlgorithm
    {
        public string Name { get; protected set; }

        // Returns list of steps. Final step has IsComplete=true and FinalPath set.
        public abstract List<PathfindingStep> Run(GridTile[,] grid, (int r, int c) start, (int r, int c) end);
    }
}