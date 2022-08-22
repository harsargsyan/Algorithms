namespace Algorithms.Sorting
{
    /**
     * time complexity of this sort is
     * O(n + rangeLength)
     * where:
     * rangeLength = secondndArrMax - secondArrMin
     */
    class Counting
    {
        internal static void CountingSort(List<int> li)
        {
            // e.g. 3 2 6 4 6 7 2
            // min=2, max=7
            int min = li.Min();
            int max = li.Max();
            int[] bucket = new int[max-min+1];
            // bucket: 2 1 1 0 2 1
            // index:  0 1 2 3 4 5
            for (int i=0; i<li.Count; i++)
            {
                bucket[li[i] - min]++;
            }
            li.Clear();
            for (int i=0; i<bucket.Length; i++)
            {
                /* bucket element shows the count of 
                 * (bucket index + min) number 
                 * for the 1st element of the bucket:
                 * there are 2 (0 + 2(min)) numbers
                 */
                int count = bucket[i];
                // i.e. for the first: 2 2 ...
                for (int j=0; j<count; j++)
                {
                    li.Add(i+min);
                }
            }
        }
    }
}
