using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 5, 1, 3, 8, 4, 0, 7, 9 };
            //SelectionSort.Selection(list);
            BubbleSort.Bubble(list);
            foreach (int i in list)
            {
                Console.Write($" {i} ");
            }
        }
    }
}
