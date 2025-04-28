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
            
            void DivideRange(int low, int high)
            {
                if (low >= high) 
                    return;
                
                var mid = (low + high) / 2;
                DivideRange(low, mid);
                DivideRange(mid + 1, high);
                MergeRange(low, mid, high);
            }
            
            void MergeRange(int low, int mid, int high)
            {
                for (var k = low; k <= high; k++)
                {
                    arr[k] = li[k];
                }
                
                int i = low;
                int j = mid + 1;
                
                for (var k = low; k <= high; k++)
                {
                    if (i > mid)
                        li[k] = arr[j++];
                    else if (j > high)
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