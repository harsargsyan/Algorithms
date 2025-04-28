namespace Algorithms.Searching
{
    /**
     * the time complexity of this search
     * algorithm is O(log(n))
     * Note: Works only on sorted arrays
     */
    class Binary
    {
        internal static bool BinarySearch(ref List<int> li, int num)
        {
            var startIndex = 0;
            var endIndex = li.Count - 1;
            while (startIndex <= endIndex)
            {
                var mid = (startIndex + endIndex) / 2;
                if (li[mid] == num)
                    return true;
                if (li[mid] < num)
                {
                    startIndex = mid + 1;
                    continue;
                }
                if (li[mid] > num)
                {
                    endIndex = mid - 1;
                }
            }
            return false;
        }
    }
}
