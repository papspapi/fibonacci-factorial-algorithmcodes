namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = [1, 2, 4, 3, 578, 300, 200, 399, 234, 300];

            PerformMergeSort(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
                Console.Write($"{inputArray[i]}  ");
        }

        private static void PerformMergeSort(int[] arr)
        {
            //count number of elements in the array
            int length = arr.Length;

            if (length <= 1)
                return;//the array is in its most basis size of 1 element

            int middleElementPosition = length / 2;//finds the middle element

            int[] leftPartition = new int[middleElementPosition];
            int[] rightPartition = new int[length - middleElementPosition];

            //populate the left partition
            for (int i = 0; i < middleElementPosition; i++) 
                leftPartition[i] = arr[i];

            //populate the right partition
            for (int i = middleElementPosition; i < length; i++)
                rightPartition[i - middleElementPosition] = arr[i];

            PerformMergeSort(leftPartition);
            PerformMergeSort(rightPartition);
            MergeTwoArrays(arr, leftPartition, rightPartition);
        }

        private static void MergeTwoArrays(int[] originalInputArray, int[] leftPartition, int[] rightPartition)
        {
            int leftSize = leftPartition.Length;
            int rightSize = rightPartition.Length;

            int i = 0, j = 0, k = 0;

            while (i < leftSize && j < rightSize)
            {
                if (leftPartition[i] <= rightPartition[j])
                {
                    originalInputArray[k++] = leftPartition[i++];
                }
                else
                {
                    originalInputArray[k++] = rightPartition[j++];
                }
            }

            while (i < leftSize)
                originalInputArray[k++] = leftPartition[i++];

            while (j < rightSize)
                originalInputArray[k++] = rightPartition[j++];
        }
    }
}
