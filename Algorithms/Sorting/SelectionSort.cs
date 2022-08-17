namespace Algorithms.Sorting
{
    internal class SelectionSort
    {
        static void SortSelection(List<int> li)
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
        
        static void Main()
        {
            List<int> list = new List<int>() { 5, 1, 3, 8, 4, 0, 7, 9 };
            SortSelection(list);
            foreach (int i in list)
            {
                Console.Write($" {i} ");
            }
        }
    }

    static class ListExtension
    {
        internal static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
