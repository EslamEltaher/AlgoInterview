////https://www.hackerrank.com/challenges/marcs-cakewalk/problem
////Greedy

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
//         * Complete the 'marcsCakewalk' function below.
//         *
//         * The function is expected to return a LONG_INTEGER.
//         * The function accepts INTEGER_ARRAY calorie as parameter.
//         */

//        public static long marcsCakewalk(List<int> calorie)
//        {
//            int[] arr = calorie.OrderByDescending(c => c).ToArray();
//            long sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//                sum += (long)Math.Pow(2, i) * arr[i];
//            return sum;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> calorie = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(calorieTemp => Convert.ToInt32(calorieTemp)).ToList();

//            long result = Result.marcsCakewalk(calorie);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
