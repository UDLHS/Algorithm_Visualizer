using System.Collections.Generic;
using System.Linq;

namespace AlgorithmVisualizer
{
    public class InsertionSort : SortingAlgorithm
    {
        public InsertionSort()
        {
            Name = "Insertion Sort";
        }

        public override List<SortStep> Run(int[] array)
        {
            var steps = new List<SortStep>();
            int[] arr = (int[])array.Clone(); // Work on a copy
            int comparisons = 0;

            // Helper: create a step snapshot
            SortStep MakeStep(int[] comparing = null, int[] swapping = null, int[] sorted = null)
            {
                return new SortStep
                {
                    Array = (int[])arr.Clone(),
                    ComparingIndices = comparing ?? new int[0],
                    SwappingIndices = swapping ?? new int[0],
                    SortedIndices = sorted ?? new int[0],
                    ComparisonCount = comparisons
                };
            }

            // Initially, nothing is sorted
            steps.Add(MakeStep());

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Record: we're about to insert arr[i]
                // The sorted portion is [0..i-1]
                var sortedSoFar = Enumerable.Range(0, i).ToArray();

                while (j >= 0)
                {
                    comparisons++;

                    // STEP: Compare arr[j] with key
                    steps.Add(MakeStep(
                        comparing: new[] { j, j + 1 },
                        sorted: sortedSoFar
                    ));

                    if (arr[j] > key)
                    {
                        // Shift arr[j] to the right
                        arr[j + 1] = arr[j];

                        // STEP: Show the shift (treat as swap/activity)
                        steps.Add(MakeStep(
                            swapping: new[] { j + 1 },
                            sorted: sortedSoFar
                        ));

                        j--;
                    }
                    else
                    {
                        break;
                    }
                }

                arr[j + 1] = key;
            }

            // Final step: everything is sorted
            steps.Add(MakeStep(
                sorted: Enumerable.Range(0, arr.Length).ToArray()
            ));

            return steps;
        }
    }
}