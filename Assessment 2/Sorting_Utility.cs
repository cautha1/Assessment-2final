using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    public static class SortingUtility<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts the given list in ascending order using the QuickSort algorithm.
        /// </summary>
        /// <param name="list">The list to be sorted.</param>
        public static void QuickSortAscending(List<T> list)
        {
            if (list == null || list.Count <= 1)
                return;

            QuickSortAscending(list, 0, list.Count - 1);
        }

        /// <summary>
        /// Sorts the given list in descending order using the QuickSort algorithm.
        /// </summary>
        /// <param name="list">The list to be sorted.</param>
        public static void SortDescending(List<T> list)
        { 
            if (list == null || list.Count <= 1)
                return;

            SortDescending(list, 0, list.Count - 1);
        }

        private static void QuickSortAscending(List<T> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionAscending(list, low, high);

                QuickSortAscending(list, low, pivotIndex - 1);
                QuickSortAscending(list, pivotIndex + 1, high);
            }
        }

        private static void SortDescending(List<T> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionDescending(list, low, high);

                SortDescending(list, low, pivotIndex - 1);
                SortDescending(list, pivotIndex + 1, high);
            }
        }

        private static int PartitionAscending(List<T> list, int low, int high)
        {
            T pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }

        private static int PartitionDescending(List<T> list, int low, int high)
        {
            T pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j].CompareTo(pivot) >= 0)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }

        private static void Swap(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
