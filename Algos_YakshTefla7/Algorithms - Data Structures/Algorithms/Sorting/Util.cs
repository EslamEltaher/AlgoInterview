using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos_YakshTefla7.Algorithms___Data_Structures.Algorithms.Sorting
{
    class Util
    {
        public static int[] CreateRandomArray(int length, int rangeStart, int rangeEnd)
        {
            int[] arr = new int[length];
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(rangeStart, rangeEnd);
            }

            return arr;
        }

        public static void PrintArray(int[] arr, int l, int r)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == l)
                    Console.Write(" | ");
                Console.Write(arr[i] + " ");
                if (i == r)
                    Console.Write(" | ");
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
