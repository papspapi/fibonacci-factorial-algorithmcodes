using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace MergeSortDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int arrayLength = 1_000_000;
            int[] inputArray = new int[arrayLength];

            Random random = new();
            for (int i = 0; i < arrayLength; i++)
                inputArray[i] = random.Next();

            Stopwatch stopwatch = Stopwatch.StartNew();
            PerformMergeSort(inputArray);
            stopwatch.Stop();

            // Save execution time to log
            string logPath = "MergeSortLog.txt";
            File.WriteAllText(logPath, $"Sorted {arrayLength:#,#} elements in {stopwatch.Elapsed.TotalMilliseconds} ms\n");

            Console.WriteLine($"\nSorted {arrayLength:#,#} elements in {stopwatch.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Log saved to {logPath}");
        }

        private static void PerformMergeSort(Span<int> arr)
        {
            if (arr.Length <= 1)
                return;

            int middle = arr.Length / 2;
            Span<int> left = arr.Slice(0, middle);
            Span<int> right = arr.Slice(middle);

            PerformMergeSort(left);
            PerformMergeSort(right);

            MergeTwoArrays(arr, left, right);
        }

        private static void MergeTwoArrays(Span<int> originalArray, Span<int> left, Span<int> right)
        {
            int leftIndex = 0, rightIndex = 0, originalIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] >= right[rightIndex]) 
                    originalArray[originalIndex++] = left[leftIndex++];
                else
                    originalArray[originalIndex++] = right[rightIndex++];
            }

            while (leftIndex < left.Length)
                originalArray[originalIndex++] = left[leftIndex++];

            while (rightIndex < right.Length)
                originalArray[originalIndex++] = right[rightIndex++];
        }
    }
}
