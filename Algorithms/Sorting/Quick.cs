using Algorithms.Helpers;

namespace Algorithms.Sorting
{
    /**
     * time complexity of this sort is
     * O(n^2)
     * average: O(n*log(n))
     */
    class Quick
    {
        private static void QuickSort(ref List<int> li, int i, int n)
        {
            if (i == n) 
                return;
            int pivot = Partition(li, i, n); // (i .. pivot) < pivot | (pivot+1 .. n) >= pivot
            // call the method recursively for the both parts
            QuickSort(ref li, i, pivot);
            QuickSort(ref li, pivot+1, n);
        }

        internal static void QuickSort(ref List<int> li)
        {
            QuickSort(ref li, 0, li.Count);
        }

        private static int Partition(List<int> li, int i, int n)
        {
            int pivot = i;
            int s1Index = i; // for num < pivot segment
            int s2Index = i; // for num >= pivot segment
            // e.g.
            // 27      | 38 12 39 27 16
            // pivot
            // s1Index
            // s2Index
            for (int k = i+1; k < n; k++)
            {
                if (li[k] >= li[pivot])
                    s2Index++;
                // 27    | 38 | 12 39 27 16
                // pivot | s2 | unknown 
                else
                {
                    s1Index++;
                    li.Swap(s1Index, k);
                    s2Index++;
                }
                // 27    | 12 | 38 | 39 27 16
                // pivot | s1 | s2 | unknown
            }
            // 27    | 12 16 | 38 39 27
            // pivot |    s1 |       s2
            li.Swap(pivot, s1Index); 
            // 16 12   | 27    | 38 39 27
            // < pivot | pivot | > =pivot
            pivot = s1Index;
            return pivot;
        }
    }
}
