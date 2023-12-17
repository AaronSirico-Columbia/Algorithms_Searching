//Binary Algorithm
//Defintion:  is a method for finding a target value within a sorted collection of elements.
//Best Case: O(1)
//Worst Case: O(log n)
//Psuedo Code:
//Begin
//function binary_search(A, n, T) is
//    L := 0
//    R:= n − 1
//    while L ≤ R do
//        m := floor((L + R) / 2)
//        if A[m] < T then
//            L := m + 1
//        else if A[m] > T then
//            R := m − 1
//        else:
//            return m
//    return unsuccessful
//End

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
