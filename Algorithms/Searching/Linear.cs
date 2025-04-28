namespace Algorithms.Searching
{
    /**
     * time complexity of this search
     * algorithm is O(n)
     */
    class Linear
    {
        internal static bool LinearSearch(List<int> li, int num)
        {
            return li.Any(i => i == num);
        }
        
        internal static int LinearSearchIndex(List<int> li, int num)
        {
            for (var i = 0; i < li.Count; i++)
            {
                if (li[i] == num)
                    return i;
            }
            return -1;
        }
    }
}