﻿////24 https://www.hackerrank.com/challenges/crush/problem

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

//class Result
//{

//    /*
//     * Complete the 'arrayManipulation' function below.
//     *
//     * The function is expected to return a LONG_INTEGER.
//     * The function accepts following parameters:
//     *  1. INTEGER n
//     *  2. 2D_INTEGER_ARRAY queries
//     */

//    public static long arrayManipulation(int n, List<List<int>> queries)
//    {
//        long[] arr = new long[n];

//        for (int i = 0; i < queries.Count; i++)
//        {
//            arr[queries[i][0] - 1] += queries[i][2];
//            if (queries[i][1] <= n - 1)
//                arr[queries[i][1]] -= queries[i][2];
//        }

//        long num = 0;
//        long max = 0;

//        for (int i = 0; i < n; i++)
//        {
//            num += arr[i];
//            max = Math.Max(max, num);
//        }

//        return max;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//        int n = Convert.ToInt32(firstMultipleInput[0]);

//        int m = Convert.ToInt32(firstMultipleInput[1]);

//        List<List<int>> queries = new List<List<int>>();

//        for (int i = 0; i < m; i++)
//        {
//            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
//        }

//        long result = Result.arrayManipulation(n, queries);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
