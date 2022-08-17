using Algorithms.Helpers;

namespace Algorithms.Sorting
{
    /**
     * time complexity of this sort is
     * (n-1) + (n-2) + ... + 1 = O(n^2) 
     */
    class SelectionSort
    {
        internal static void Selection(List<int> li)
        {
            for (int i = 0; i < li.Count; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[j] < li[minIndex])
                    {
                        minIndex = j;
                    }
                }
                ListExtension.Swap(li, minIndex, i);
            }
        }
    }
}
