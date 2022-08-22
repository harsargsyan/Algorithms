namespace Algorithms.Sorting
{
    /**
     * time complexity of this sort is
     * 1 + 2 + ... + (n-1) = O(n^2) 
     */
    class Insertion
    {
        internal static void InsertionSort(List<int> li)
        {
            for (int i = 1; i < li.Count; i++)
            {
                int cur = li[i];
                int j = i - 1;
                while (j >= 0 && cur < li[j])
                {
                    li[j+1] = li[j];
                    j--;
                }
                li[j+1] = cur;
            }
        }
    }
}
