////https://www.hackerrank.com/challenges/missing-numbers/problem

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
//         * Complete the 'missingNumbers' function below.
//         *
//         * The function is expected to return an INTEGER_ARRAY.
//         * The function accepts following parameters:
//         *  1. INTEGER_ARRAY arr
//         *  2. INTEGER_ARRAY brr
//         */

//        public static List<int> missingNumbers(List<int> arr, List<int> brr)
//        {
//            int[] count = new int[10000];
//            int[] bcount = new int[10000];

//            for (int i = 0; i < arr.Count; i++)
//            {
//                count[arr[i] - 1]++;
//            }

//            for (int i = 0; i < brr.Count; i++)
//            {
//                bcount[brr[i] - 1]++;
//            }

//            List<int> result = new List<int>();
//            for (int i = 0; i < 10000; i++)
//            {
//                if (bcount[i] > count[i])
//                {
//                    result.Add(i + 1);
//                }
//            }
//            return result;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//            int m = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

//            List<int> result = Result.missingNumbers(arr, brr);

//            textWriter.WriteLine(String.Join(" ", result));

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
