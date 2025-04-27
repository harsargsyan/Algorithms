namespace Algorithms.Searching
{
    /**
     * time complexity of this search
     * algorithm is O(log(n))
     */
    class Binary
    {
        internal static bool BinarySearch(ref List<int> li, int num)
        {
            int startIndex = 0;
            int endIndex = li.Count - 1;
            while (startIndex <= endIndex)
            {
                int mid = (startIndex + endIndex) >> 1; // or mid = (startIndex + endIndex) / 2;
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
