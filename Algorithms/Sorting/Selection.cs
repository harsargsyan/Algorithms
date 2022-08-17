using Algorithms.Helpers;

namespace Algorithms.Sorting
{
    class Selection
    {
        internal static void SelectionSort(List<int> li)
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
