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
        internal static void QuickSort(ref List<int> li)
        {
            QuickSort(ref li, 0, li.Count);
        }
        
        private static void QuickSort(ref List<int> li, int start, int end)
        {
            if (start == end) 
                return;
            int pivot = Partition(li, start, end); // (start .. pivot) < pivot | (pivot+1 .. end) >= pivot
            // call the method recursively for the both parts
            QuickSort(ref li, start, pivot);
            QuickSort(ref li, pivot+1, end);
        }

        private static int Partition(List<int> li, int startIndex, int endIndex)
        {
            int pivot = startIndex;
            int s1Index = startIndex; // for num < pivot segment
            int s2Index = startIndex; // for num >= pivot segment
            // e.g.
            // 27      | 38 12 39 27 16
            // pivot
            // s1Index
            // s2Index
            for (int k = startIndex+1; k < endIndex; k++)
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
