using System.Diagnostics;

namespace QuickSort.Services
{
    public class SortingService
    {
        public (int[] sortedArray, string executionTime) BubbleSort(int[] array)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = (int[])array.Clone();

            int n = result.Length;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                        // Swap elements
                        int temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            stopwatch.Stop();
            return (result, $"{stopwatch.ElapsedMilliseconds} ms");
        }

        public (int[] sortedArray, string executionTime) QuickSort(int[] array)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = (int[])array.Clone();

            QuickSortAlgorithm(result, 0, result.Length - 1);

            stopwatch.Stop();
            return (result, $"{stopwatch.ElapsedMilliseconds} ms");
        }

        private void QuickSortAlgorithm(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                QuickSortAlgorithm(array, low, partitionIndex - 1);
                QuickSortAlgorithm(array, partitionIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        public int[] ParseNumbers(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return Array.Empty<int>();

            return input.Split(',')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s) && int.TryParse(s, out _))
                .Select(int.Parse)
                .ToArray();
        }
    }
}
