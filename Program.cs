using System.Diagnostics;

namespace MergeSort
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


            Stopwatch stopwatch = new();
            stopwatch.Start();

            PerformMergeSort(inputArray);

            stopwatch.Stop();

            for (int i = 0; i < inputArray.Length; i++)
                Console.Write($"{inputArray[i]}  ");

            Console.WriteLine();
            Console.WriteLine($"Sorted {arrayLength:#,#} elements in {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }

        private static void PerformMergeSort(int[] arr)
        {
            //count number of elements in the array
            int length = arr.Length;

            if (length <= 1)
                return;//the array is in its most basis size of 1 element

            int middleElementPosition = length / 2;//finds the middle element

            //initialize left and right partitions
            int[] leftPartition = new int[middleElementPosition];
            int[] rightPartition = new int[length - middleElementPosition];

            //populate the left partition
            for (int i = 0; i < middleElementPosition; i++)
                leftPartition[i] = arr[i];

            //populate the right partition
            for (int i = middleElementPosition; i < length; i++)
                rightPartition[i - middleElementPosition] = arr[i];


            PerformMergeSort(leftPartition);//recursively sort the left partition
            PerformMergeSort(rightPartition);//recursively sort the right partition
            MergeTwoArrays(arr, leftPartition, rightPartition);//merge both the left and right partitions
        }

        private static void MergeTwoArrays(int[] originalInputArray, int[] leftPartition, int[] rightPartition)
        {
            int leftSize = leftPartition.Length;//size of the left partion
            int rightSize = rightPartition.Length;//size of the right partition

            int leftPartitionIterator = 0, rightPartitionIterator = 0, originalArrayIterator = 0;

            //swap in elements in the original array
            while (leftPartitionIterator < leftSize && rightPartitionIterator < rightSize)
            {
                if (leftPartition[leftPartitionIterator] <= rightPartition[rightPartitionIterator])
                    originalInputArray[originalArrayIterator++] = leftPartition[leftPartitionIterator++];//the element in the left partition is less than that in the right partition, so slot it in the original and increment the affected iterators
                else
                    originalInputArray[originalArrayIterator++] = rightPartition[rightPartitionIterator++];//the element in the right partition is less than that in the left partition, so slot it in the original and increment the affected iterators
            }

            //slot in the remaining elements in the left partition
            while (leftPartitionIterator < leftSize)
                originalInputArray[originalArrayIterator++] = leftPartition[leftPartitionIterator++];

            //slot in the remaining elements in the right partition
            while (rightPartitionIterator < rightSize)
                originalInputArray[originalArrayIterator++] = rightPartition[rightPartitionIterator++];
        }
    }
}
