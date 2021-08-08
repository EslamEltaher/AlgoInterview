//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algos_YakshTefla7.Algorithms___Data_Structures.Algorithms.Sorting
//{
//    class QuickSort_Algorithm
//    {
//        public static void Sort(int[] arr)
//        {
//            QuickSort(arr, 0, arr.Length - 1);
//        }

//        public static void QuickSort(int[] arr, int l, int r)
//        {
//            if (l == r)
//                return;

//            if (l > r)
//                return;

//            if (r - l == 1)
//            {
//                if (arr[r] < arr[l])
//                    Swap(arr, r, l);

//                return;
//            }

//            int pivot = (l + r) / 2;

//            //Console.WriteLine("\n \n pivot  = " + arr[pivot]);
//            Swap(arr, pivot, l);
//            int sortedIndex = l + 1;

//            for (int i = sortedIndex; i <= r; i++)
//            {
//                if (arr[i] < arr[l])
//                {
//                    Swap(arr, i, sortedIndex);
//                    sortedIndex++;
//                }
//            }

//            //if (sortedIndex == r + 1)
//            sortedIndex--;

//            //printArray(arr, l, r);

//            if (sortedIndex != l)
//                Swap(arr, l, sortedIndex);

//            if (l < sortedIndex)
//                QuickSort(arr, l, sortedIndex - 1);

//            if (r > sortedIndex)
//                QuickSort(arr, sortedIndex + 1, r);
//        }

//        public static void Swap(int[] arr, int i, int j)
//        {
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }

        
//    }

//    class QuickSort_Algorithm_Interative
//    {
//        public static void Sort(int[] arr)
//        {
//            QuickSort(arr);
//        }

//        public static void QuickSort(int[] arr)
//        {
//            var queue = new Queue<Tuple<int, int>>();

//            queue.Enqueue(new Tuple<int, int>(0, arr.Length - 1));

//            while (queue.Count > 0)
//            {
//                var current = queue.Dequeue();
//                int l = current.Item1;
//                int r = current.Item2;

//                if (l == r)
//                    return;

//                if (l > r)
//                    return;

//                if (r - l == 1)
//                {
//                    if (arr[r] < arr[l])
//                        Swap(arr, r, l);

//                    return;
//                }

//                int pivot = (l + r) / 2;

//                //Console.WriteLine("\n \n pivot  = " + arr[pivot]);
//                Swap(arr, pivot, l);
//                int sortedIndex = l + 1;

//                for (int i = sortedIndex; i <= r; i++)
//                {
//                    if (arr[i] < arr[l])
//                    {
//                        Swap(arr, i, sortedIndex);
//                        sortedIndex++;
//                    }
//                }

//                //if (sortedIndex == r + 1)
//                sortedIndex--;

//                //printArray(arr, l, r);

//                if (sortedIndex != l)
//                    Swap(arr, l, sortedIndex);

//                if (l < sortedIndex)
//                    queue.Enqueue(new Tuple<int, int>(l, sortedIndex - 1));
//                //QuickSort(arr, l, sortedIndex - 1);

//                if (r > sortedIndex)
//                    queue.Enqueue(new Tuple<int, int>(sortedIndex + 1, r));
//                //QuickSort(arr, sortedIndex + 1, r);
//            }
//        }

//        public static void Swap(int[] arr, int i, int j)
//        {
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//    }


//    public class Program
//    {
//        public static void Main2(string[] args)
//        {
//            int[] arr = Util.CreateRandomArray(100, 1, 300);

//            Console.Write("\n");

//            Console.ReadLine();

//            QuickSort_Algorithm.Sort(arr);

//            Console.WriteLine("\n\n Final: \n");

//            Util.PrintArray(arr);

//            Console.ReadLine();
//        }
//    }

//    public class ProgramTest
//    {
//        public static void Main(string[] args)
//        {
//            int[] lens = { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000 };
//            for (int x = 0; x < 10; x++)
//            {
//                Console.ReadLine();

//                int len = lens[x];
//                int[] arr = Util.CreateRandomArray(len, 1, 300);

//                Console.Write("\n Total = " + len);

//                Console.ReadLine();

//                Stopwatch watch = new Stopwatch();
//                watch.Start();
//                QuickSort_Algorithm_Interative.Sort(arr);
//                watch.Stop();

//                Console.WriteLine("\n\nTiming: " + watch.ElapsedMilliseconds + " Ms");

//                //Util.PrintArray(arr);
//            }

//            Console.ReadLine();
//        }
//    }
//}
