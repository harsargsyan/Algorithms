﻿using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 5, 1, 3, 8, 4, 0, 7, 9 };
            //Selection.SelectionSort(list);
            Bubble.BubbleSort(list);
            foreach (int i in list)
            {
                Console.Write($" {i} ");
            }
        }
    }
}
