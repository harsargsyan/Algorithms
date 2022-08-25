using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1,5,8 };
            List<int> list2 = new List<int>() { 3,4,6,9 };
            //Selection.SelectionSort(list);
            //Bubble.BubbleSort(list);
            //Insertion.InsertionSort(list);
            //Counting.CountingSort(list);
            List<int> merged = Merge.MergeLists(list, list2);
            foreach (int i in merged)
            {
                Console.Write($" {i} ");
            }
        }
    }
}
