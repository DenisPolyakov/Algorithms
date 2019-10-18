using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        public static int[] sortedArray = { -4, -2, 1, 5, 8, 9, 10 };
        public static int[] unsortedArray = {0, -2, 4, 5, -4, -2, 10 };
        static void Main(string[] args)
        {
            Sort.BubbleSort(unsortedArray);


            BinarySearch.IterativeBinarySearch(sortedArray, 10);
            BinarySearch.RecursiveBinarySearch(sortedArray, 10, 0, sortedArray.Length-1);
            Console.ReadKey();
        }

       
    }
}
