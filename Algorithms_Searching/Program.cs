namespace Algorithms_Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var path = ($"{Directory.GetCurrentDirectory()}\\Files\\scores.txt");

            Utility util = new Utility();
            

            LinearSearch linearSearch = new LinearSearch();
            linearSearch.LinearSearchMethod(util.ReadDataFromFile(path), 73);

            BinarySearch binarySearch = new BinarySearch();
            binarySearch.BinarySearchMethod(util.ReadDataFromFile(path), 69);

            InterpolationSearch interpolationSearch = new InterpolationSearch();
            interpolationSearch.InterpolationSearchMethod(util.ReadDataFromFile(path), 62);

        }
    }
}