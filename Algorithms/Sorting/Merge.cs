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
        internal static void MergeSort(List<int> li)
        {

        }

        internal static List<int> MergeLists(List<int> l1, List<int> l2)
        {
            List<int> merged = new List<int>();
            int i = 0, j = 0;
            while (i < l1.Count && j < l2.Count)
            {
                if (l1[i] < l2[j])
                {
                    merged.Add(l1[i++]);
                }
                else
                {
                    merged.Add(l2[j++]);
                }
            }
            return merged;
        }
    }
}
