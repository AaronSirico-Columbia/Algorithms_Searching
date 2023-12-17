//Interpolation Algorithm
//Defintion:is an algorithm used for searching a specific value in a sorted array. 
//Best Case: O(1)
//Worst Case: O(n)
//Psuedo Code:
//Begin
//function InterpolationSearch(array, value):
//    low = 0
//    high = array.Length - 1

//    while low <= high and value >= array[low] and value <= array[high]:
//        // Estimate the position of the value
//        pos = low + ((value - array[low]) * (high - low)) / (array[high] - array[low])

//        if array[pos] == value:
//            return pos // Return the index if the value is found
//        else if array[pos] < value:
//            low = pos + 1
//        else:
//            high = pos - 1

//    return -1 // Return -1 if the value is not found
//End
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Searching
{
    internal class InterpolationSearch
    {
        public int InterpolationSearchMethod(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high && value >= array[low] && value <= array[high])
            {
                // Estimate the position of the value
                int pos = low + ((value - array[low]) * (high - low)) / (array[high] - array[low]);

                if (array[pos] == value)
                {
                    Console.WriteLine($"Interpolation Search\nIndex of Value: {pos}");
                    return pos; // Return the index if the value is found
                }
                else if (array[pos] < value)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }

            return -1; // Return -1 if the value is not found
        }
    }
}
