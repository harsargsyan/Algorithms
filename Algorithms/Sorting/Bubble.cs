using Algorithms.Helpers;

namespace Algorithms.Sorting
{
    /**
     * time complexity of this sort is
     * (n-1) + (n-2) + ... + 1 = O(n^2) 
     */
    class Bubble
    {
        internal static void BubbleSort(List<int> li)
        {
            for (int i = 0; i < li.Count; i++)
            {
                bool isSorted = true;
                for (int j = 1; j < li.Count - i; j++)
                {
                    if (li[j] < li[j-1])
                    {
                        isSorted = false;
                        ListExtension.Swap(li, j, j-1);
                    }
                }
                if (isSorted)
                    return;
            }
        }
    }
}
