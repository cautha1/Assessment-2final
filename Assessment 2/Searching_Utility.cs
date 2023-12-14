using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    public static class SearchingUtility<T> where T : IComparable<T>
    {
        /// <summary>
        /// BinarySearch method for searching a target in a sorted list.
        /// </summary>
        /// <param name="sortedList">The sorted list to search in.</param>
        /// <param name="target">The target item to search for.</param>
        /// <returns>True if the target is found; otherwise, false.</returns>
        public static bool BinarySearch(List<T> sortedList, T target)
        {
            int low = 0;
            int high = sortedList.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparisonResult = sortedList[mid].CompareTo(target);

                if (comparisonResult == 0)
                {
                    // Found the target
                    return true;
                }
                else if (comparisonResult < 0)
                {
                    // Target is in the right half
                    low = mid + 1;
                }
                else
                {
                    // Target is in the left half
                    high = mid - 1;
                }
            }

            // Target not found
            return false;
        }

        /// <summary>
        /// LinearSearch method for searching a target in an unsorted list.
        /// </summary>
        /// <param name="unsortedList">The unsorted list to search in.</param>
        /// <param name="target">The target item to search for.</param>
        /// <returns>The index of the target if found; otherwise, -1.</returns>
        public static int LinearSearch(List<T> unsortedList, T target)
        {
            for (int i = 0; i < unsortedList.Count; i++)
            {
                if (unsortedList[i].CompareTo(target) == 0)
                {
                    return i; // Item found, return the index
                }
            }

            // Item not found, return -1
            return -1;
        }
    }
}
