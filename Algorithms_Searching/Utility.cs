using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms_Searching
{
    public class Utility
    {
        DataSorter sort = new DataSorter(); 
        public static string path = ($"{Directory.GetCurrentDirectory()}\\files");

        public int[] ReadDataFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] dataArray = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                dataArray[i] = int.Parse(lines[i]);
            }

            return sort.SetUpBubbleSort(dataArray);
        }



    }
}




