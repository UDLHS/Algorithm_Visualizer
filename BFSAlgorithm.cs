using System.Collections.Generic;

namespace AlgorithmVisualizer
{
    public class BFSAlgorithm : PathfindingAlgorithm
    {
        public BFSAlgorithm()
        {
            Name = "Breadth-First Search";
        }

        public override List<PathfindingStep> Run(GridTile[,] grid, (int r, int c) start, (int r, int c) end)
        {
            var steps = new List<PathfindingStep>();
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            bool[,] visited = new bool[rows, cols];
            (int r, int c)[,] parent = new (int, int)[rows, cols];
            var queue = new Queue<(int r, int c)>();

            queue.Enqueue(start);
            visited[start.r, start.c] = true;

            // Directions: up, down, left, right
            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                // Record: we are visiting this node
                var visitStep = new PathfindingStep();
                visitStep.NewlyVisited.Add(current);
                steps.Add(visitStep);

                // If we reached the end, stop expanding
                if (current.r == end.r && current.c == end.c)
                    break;

                // Explore neighbors
                for (int i = 0; i < 4; i++)
                {
                    int nr = current.r + dr[i];
                    int nc = current.c + dc[i];

                    if (nr >= 0 && nr < rows && nc >= 0 && nc < cols
                        && !visited[nr, nc]
                        && grid[nr, nc].Type != TileType.Wall)
                    {
                        visited[nr, nc] = true;
                        parent[nr, nc] = current;
                        queue.Enqueue((nr, nc));
                    }
                }
            }

            // Reconstruct path
            if (visited[end.r, end.c])
            {
                var path = new List<(int, int)>();
                var at = end;

                while (at != start)
                {
                    path.Add(at);
                    at = parent[at.r, at.c];
                }
                path.Add(start);
                path.Reverse();

                steps.Add(new PathfindingStep
                {
                    IsComplete = true,
                    FinalPath = path
                });
            }
            else
            {
                // No path found
                steps.Add(new PathfindingStep { IsComplete = true });
            }

            return steps;
        }
    }
}