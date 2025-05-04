using System.Globalization;
using Algorithms.DynamicProgramming;
using Algorithms.Sorting;
using Algorithms.Searching;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            var list = new List<int>() { 5, 0, 1, 6, 9, 2, 4, 7, 3, 8 };
            var sortedList = new List<int>() { 0, 1, 3, 4, 7, 10, 14, 17, 21 };

            // var li = Merge.MergeSort(list);
            // Console.WriteLine(string.Join(", ", li));
            //
            // Quick.QuickSort(ref list);
            // Console.WriteLine(string.Join(", ", list));
            
            // Console.WriteLine(CoinChangeSolver.CoinChange(new int[] { 1, 2, 5 }, 11));
            
        }
    }
}
