﻿////https://www.hackerrank.com/challenges/beautiful-pairs/problem
////greedy

//XXXXX

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
//         * Complete the 'beautifulPairs' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER_ARRAY A
//         *  2. INTEGER_ARRAY B
//         */

//        public static int beautifulPairs(List<int> A, List<int> B)
//        {
//            int length = A.Count;
//            HashSet<int>[] arr = new HashSet<int>[length];

//            for (int i = 0; i < length; i++)
//            {
//                int num = A[i];
//                arr[i] = new HashSet<int>();
//                for (int j = 0; j < length; j++)
//                {
//                    if (num == B[j])
//                        arr[i].Add(j);
//                }
//            }

//            int count = 0;
//            bool x = false;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i].Count == 1)
//                    count++;
//                else if (arr[i].Count == 2)
//                    x = true;
//            }
//            if (x)
//                count += 2;
//            else
//                count++;
//            return count;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

//            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

//            int result = Result.beautifulPairs(A, B);

//            //textWriter.WriteLine(result);

//            //textWriter.Flush();
//            //textWriter.Close();
//        }
//    }

//}
