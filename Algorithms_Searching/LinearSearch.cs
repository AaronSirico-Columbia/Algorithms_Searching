//Linear Algorithm
//Defintion: is a straightforward method for finding a target value within a list or array
//Best Case: O(1)
//Worst Case: O(n)
//Psuedo Code:
//Begin
//1) Set i = 0
//2) If Li = T, go to line 4
//3) Increase i by 1 and go to line 2
//4) If i<n then return i
//End

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Searching
{
    internal class LinearSearch
    {

        public int LinearSearchMethod(int[] array, int value)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Console.WriteLine($"Linear Search\nIndex of Value: {i}");
                    return i; // Return the index if the value is found
                }
            }
            Console.WriteLine("Value not Found");
            return -1; // Return -1 if the value is not found
        }
    }
}
