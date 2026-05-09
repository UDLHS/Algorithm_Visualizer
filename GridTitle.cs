using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer
{
    public enum TileType
    {
        Empty,      // White
        Wall,       // Black
        Start,      // Green
        End,        // Red
        Visited,    // Light Blue
        Path        // Yellow
    }

    public class GridTile
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public TileType Type { get; set; } = TileType.Empty;
    }
}