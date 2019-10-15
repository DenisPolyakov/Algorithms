using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinarySearch
    {
        //mass {0, 1, 2, 3, 4, 5}
        public static int IterativeBinarySearch(int[] mass, int key)
        {
            int left = 0;
            int right = mass.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left);
                if (key < mass[middle])
                {

                    right = middle - 1;
                }
                else if (key > mass[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    Console.WriteLine("IterativeBinarySearch: Index of {0} = {1}", key, middle);
                    return middle;
                }
            }
            return -1;
        }



        // -4, -2, 1, 5, 8, 10, 15      k10
        public static int RecursiveBinarySearch(int[] mass, int key, int left, int right)
        {
            if (right >= left)
            {
                int middle = left + (right - left) / 2;
                if (key < mass[middle])
                {

                    RecursiveBinarySearch(mass, key, left, middle - 1);
                }
                else if (key > mass[middle])
                {

                    RecursiveBinarySearch(mass, key, middle + 1, right);
                }
                else
                {
                    Console.WriteLine("RecursiveBinarySearch: Index of {0} = {1}", key, middle);
                    return middle;
                }
            }
            return -1;
        }

    }
}
