using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer
{
    public class VisualizerSettings
    {
        // Sorting settings
        public int ArraySize { get; set; } = 50;
        public int AnimationDelayMs { get; set; } = 100;

        // Pathfinding settings
        public int GridRows { get; set; } = 20;
        public int GridCols { get; set; } = 30;
    }
}
