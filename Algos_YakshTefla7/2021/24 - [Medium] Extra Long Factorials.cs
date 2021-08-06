////https://www.hackerrank.com/challenges/extra-long-factorials/problem

//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//namespace Algos_YakshTefla7._2021
//{

//    class Result
//    {

//        /*
//         * Complete the 'extraLongFactorials' function below.
//         *
//         * The function accepts INTEGER n as parameter.
//         */

//        public static void extraLongFactorials(int n)
//        {
//            int[] result = breakDown(n);

//            n--;
//            while (n > 0)
//            {
//                int[] nn = breakDown(n);
//                result = multiply(result, nn);
//                n--;

//                // Console.WriteLine(n);
//                // Console.WriteLine(result);
//            }

//            result = result.Reverse().ToArray();
//            // Console.WriteLine(result);
//            for (int i = 0; i < result.Length; i++)
//            {
//                Console.Write(result[i]);
//            }
//        }

//        public static int[] multiply(int[] a, int[] b)
//        {
//            int[] result = new int[a.Length + b.Length];

//            for (int i = 0; i < a.Length; i++)
//            {
//                for (int j = 0; j < b.Length; j++)
//                {
//                    int cell = a[i] * b[j];

//                    int pos = i + j;

//                    cell += result[pos];

//                    int[] cellBroken = breakDown(cell);

//                    int rem = 0;

//                    for (int x = 0; x < cellBroken.Length; x++)
//                    {
//                        cellBroken[x] += rem;
//                        int newCell = x == 0 ? cellBroken[x] : cellBroken[x] + result[pos + x];
//                        rem = newCell / 10;
//                        newCell %= 10;

//                        result[pos + x] = newCell;
//                    }

//                    if(rem != 0)
//                    {
//                        result[pos + cellBroken.Length] = rem;
//                    }
//                }
//            }

//            int len = result.Length;

//            for (int i = result.Length - 1; i >= 0; i--)
//            {
//                if (result[i] != 0)
//                    break;

//                len--;
//            }

//            if (len != result.Length)
//            {
//                int[] newArr = new int[len];
//                for (int i = 0; i < len; i++)
//                {
//                    newArr[i] = result[i];
//                }
//                result = newArr;
//            }

//            return result;
//        }

//        public static int[] breakDown(int a)
//        {
//            List<int> num = new List<int>();

//            while (a > 0)
//            {
//                num.Add(a % 10);
//                a /= 10;
//            }
//            //num.Reverse();
//            return num.ToArray();
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            Result.extraLongFactorials(n);
//        }
//    }

//}
