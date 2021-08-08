//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algos_YakshTefla7.Algorithms___Data_Structures.Algorithms.Sorting
//{
//    class MergeSort_Algorithm
//    {
//        public static void Sort(int[] arr)
//        {
//            MergeSort(arr, 0, arr.Length - 1);
//        }

//        public static void MergeSort(int[] arr, int l, int r)
//        {
//            if (l == r)
//                return;

//            int mid = (l + r) / 2;

            

//            MergeSort(arr, l, mid);
//            MergeSort(arr, mid + 1, r);

//            //MergeSort(larr, 0, larr.Length - 1);
//            //MergeSort(rarr, 0, rarr.Length - 1);

//            int[] larr = new int[mid - l + 1];
//            int[] rarr = new int[r - mid];

//            for (int i = l; i <= mid; i++)
//            {
//                larr[i - l] = arr[i];
//            }

//            for(int i  = mid + 1; i <= r; i++)
//            {
//                rarr[i - mid - 1] = arr[i];
//            }

//            int ll = 0;
//            int rr = 0;

//            int j = l;
//            while (ll < larr.Length || rr < rarr.Length)
//            {
//                if (ll >= larr.Length)
//                {
//                    arr[j++] = rarr[rr++];
//                }
//                else if (rr >= rarr.Length)
//                {
//                    arr[j++] = larr[ll++];
//                }
//                else if(rarr[rr] < larr[ll])
//                {
//                    arr[j++] = rarr[rr++];
//                }
//                else
//                {
//                    arr[j++] = larr[ll++];
//                }
//            }

//            Util.PrintArray(arr, l, r);
//            Console.WriteLine("\n--------------");
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

//            MergeSort_Algorithm.Sort(arr);

//            Console.WriteLine("\n\n Final: \n");

//            Util.PrintArray(arr);

//            Console.ReadLine();
//        }
//    }

//}
