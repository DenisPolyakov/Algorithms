using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Sort
    {
        public static void BubbleSort(int[] array)
        {
            string inputArray;
           string outputArray;


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~Bubble Sort~\n");
          
            Console.ForegroundColor = ConsoleColor.Green;
             inputArray = String.Join(", ", array.ToArray());
            Console.WriteLine("Input array: {0}\n", inputArray);

            for(int j=0;j<array.Length;j++)
            for (int i =0;i<array.Length-2;i++)
            {
                if (array[i]>array[i+1])
                {
                    array[i] = array[i] + array[i + 1];
                    array[i + 1] = array[i] - array[i + 1];
                    array[i] = array[i] - array[i + 1];
                }
            }


            outputArray = String.Join(", ", array.ToArray());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Output array: {0}\n",outputArray);

        }
    }
}
