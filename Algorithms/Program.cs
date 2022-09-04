using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 5, 0, 1, 6, 9, 2, 4, 7, 3, 8 };
            //Selection.SelectionSort(list);
            //Bubble.BubbleSort(list);
            //Insertion.InsertionSort(list);
            //Counting.CountingSort(list);
            //Merge.MergeSort(ref list);
            Quick.QuickSort(ref list);
            foreach (int i in list)
            {
                Console.Write($" {i} ");
            }
        }
    }
}
