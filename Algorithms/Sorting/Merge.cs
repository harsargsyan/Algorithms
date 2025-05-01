namespace Algorithms.Sorting
{
    /**
     * time complexity of this sort is
     * there are log2(n) levels
     * in each level we do n steps
     * total for the best/worst cases: O(n*Log2(n))
     */
    class Merge
    {
        internal static List<int> MergeSort(List<int> li)
        {
            if (li.Count <= 1)
                return li;
            
            int[] arr = new int[li.Count];
            
            void DivideRange(int start, int end)
            {
                if (start == end) 
                    return;
                
                var mid = (start + end) / 2;
                DivideRange(start, mid);
                DivideRange(mid + 1, end);
                MergeRange(start, mid, end);
            }
            
            void MergeRange(int start, int mid, int end)
            {
                for (var k = start; k <= end; k++)
                {
                    arr[k] = li[k];
                }
                
                int i = start;
                int j = mid + 1;
                
                for (var k = start; k <= end; k++)
                {
                    if (i > mid)
                        li[k] = arr[j++];
                    else if (j > end)
                        li[k] = arr[i++];
                    else if (arr[i] <= arr[j])
                        li[k] = arr[i++];
                    else
                        li[k] = arr[j++];
                }
            }
            
            DivideRange(0, li.Count - 1);
            return li;
        }
    }
}