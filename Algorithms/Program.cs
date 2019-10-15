using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        public static int[] SortedMass = { -4, -2, 1, 5, 8, 10, 15 };
        static void Main(string[] args)
        {
            BinarySearch.IterativeBinarySearch(SortedMass, 10);
            BinarySearch.RecursiveBinarySearch(SortedMass, 10, 0, SortedMass.Length-1);
            Console.ReadKey();
        }

       
    }
}
