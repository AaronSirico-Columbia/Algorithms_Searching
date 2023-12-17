//Binary Algorithm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Searching
{
    internal class BinarySearch
    {
        public int BinarySearchMethod(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == value)
                {
                    Console.WriteLine($"Binary Search\nIndex of Value: {mid}");
                    return mid; // Return the index if the value is found
                }
                else if (array[mid] < value)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Return -1 if the value is not found
        }
    }
}
