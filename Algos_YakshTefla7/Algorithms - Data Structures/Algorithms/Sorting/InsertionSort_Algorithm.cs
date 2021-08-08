//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algos_YakshTefla7.Algorithms___Data_Structures.Algorithms.Sorting
//{
//    class InsertionSort_Algorithm
//    {
//        public static void Sort(int[] arr)
//        {
//            if (arr.Length < 2)
//                return;

//            for (int i = 1; i < arr.Length; i++)
//            {
//                int element = arr[i];

//                Util.PrintArray(arr, i, -1);
//                Console.Write("\n---------------------------------------\n");

//                int j = i - 1;

//                while (j >= 0 && arr[j] > element)
//                {
//                    arr[j + 1] = arr[j];
//                    j--;
//                }

//                arr[j + 1] = element;
//            }
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = Util.CreateRandomArray(30, 1, 300);

//            Console.Write("\n");
//            Util.PrintArray(arr);
//            Console.Write("\n");

//            Console.ReadLine();

//            InsertionSort_Algorithm.Sort(arr);

//            Console.WriteLine("\n\n Final: \n");

//            Util.PrintArray(arr);

//            Console.ReadLine();
//        }
//    }

//    public class ProgramTest
//    {
//        public static void Main2(string[] args)
//        {
//            int[] lens = { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000 };
//            for (int x = 0; x < 10; x++)
//            {
//                Console.ReadLine();

//                int len = lens[x];
//                int[] arr = Util.CreateRandomArray(len, 1, 300);

//                Console.Write("\n Total = " + len);

//                Console.ReadLine();

//                var watch = new System.Diagnostics.Stopwatch();
//                watch.Start();
//                InsertionSort_Algorithm.Sort(arr);
//                watch.Stop();

//                Console.WriteLine("\n\nTiming: " + watch.ElapsedMilliseconds + " Ms");

//                //Util.PrintArray(arr);
//            }

//            Console.ReadLine();
//        }
//    }
//}
