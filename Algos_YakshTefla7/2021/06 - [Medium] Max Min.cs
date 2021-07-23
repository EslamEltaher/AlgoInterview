////https://www.hackerrank.com/challenges/angry-children/problem

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
//         * Complete the 'maxMin' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER k
//         *  2. INTEGER_ARRAY arr
//         */

//        public static int maxMin(int k, List<int> arr)
//        {
//            int n = arr.Count;
//            arr.Sort();
//            if (k >= n)
//                return arr[n - 1] - arr[0];

//            int min = arr[k - 1] - arr[0];
//            for (int i = 0; i < n - k + 1; i++)
//            {
//                if (arr[i + k - 1] - arr[i] < min)
//                    min = arr[i + k - 1] - arr[i];
//            }
//            return min;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            int k = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = new List<int>();

//            for (int i = 0; i < n; i++)
//            {
//                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
//                arr.Add(arrItem);
//            }

//            int result = Result.maxMin(k, arr);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
