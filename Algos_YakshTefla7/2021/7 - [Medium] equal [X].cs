////https://www.hackerrank.com/challenges/equal/problem

////stuck at 4 test cases (and i don't know why they are not succeeding)

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
//         * Complete the 'equal' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts INTEGER_ARRAY arr as parameter.
//         */

//        public static int equal(List<int> arr)
//        {
//            arr.Sort();
//            int[] diffs = new int[1000];
//            arr.ForEach(e => diffs[e - arr[0]]++);

//            int times = 0;
//            for (int i = 1; i < 1000; i++)
//            {
//                int rem5 = i % 5;
//                int mul5 = i / 5;

//                int rem = 0;
//                if (rem5 == 1 || rem5 == 2)
//                    rem = 1;
//                if (rem5 == 3 || rem5 == 4)
//                    rem = 2;

//                times += (mul5 + rem) * diffs[i];
//            }

//            return times;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int t = Convert.ToInt32(Console.ReadLine().Trim());

//            for (int tItr = 0; tItr < t; tItr++)
//            {
//                int n = Convert.ToInt32(Console.ReadLine().Trim());

//                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//                int result = Result.equal(arr);

//                textWriter.WriteLine(result);
//            }

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
