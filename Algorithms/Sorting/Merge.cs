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
        /**
         * split an array into two parts recursively
         * until the length is 1
         */
        internal static void MergeSort(ref List<int> li)
        {
            if (li.Count <= 1)
                return;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int half = li.Count / 2;
            for (int i = 0; i < half; i++)
                left.Add(li[i]);
            for (int j = half; j < li.Count; j++)
                right.Add(li[j]);
            MergeSort(ref left);
            MergeSort(ref right);
            li = MergeLists(left, right);
        }

        /**
         * merge 2 sorted lists
         */
        internal static List<int> MergeLists(List<int> l1, List<int> l2)
        {
            List<int> merged = new List<int>();
            int i = 0, j = 0;
            while (i < l1.Count && j < l2.Count)
            {
                if (l1[i] < l2[j])
                    merged.Add(l1[i++]);
                else
                    merged.Add(l2[j++]);
            }
            while (i < l1.Count)
                merged.Add(l1[i++]);
            while (j < l2.Count)
                merged.Add(l2[j++]);
            return merged;
        }
    }
}
