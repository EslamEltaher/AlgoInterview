////28 https://www.hackerrank.com/challenges/ctci-merge-sort/problem

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
//     * Complete the 'countInversions' function below.
//     *
//     * The function is expected to return a LONG_INTEGER.
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static long countInversions(List<int> arr)
//    {
//        // 2 1 3 1 2
//        // i = 0 j = 1   1 2 3 1 2   count 1
//        // i = 0 j = 2   1 2 3 1 2   count 1
//        // i = 0 j = 3   1 2 1 3 2   count 2
//        // i = 0 j = 4   1 2 1 2 2   count 2 temp 3

//        //long count = 0;
//        //for (int i = 0; i < arr.Count - 1; i++)
//        //{
//        //    for (int j = 1; j < arr.Count - i; j++)
//        //    {
//        //        if (arr[j - 1] > arr[j])
//        //        {
//        //            swap(arr, j - 1, j);
//        //            count++;
//        //        }
//        //    }
//        //}
//        return mergeSort(arr, 0, arr.Count - 1);
//    }

//    public static long mergeSort(List<int> arr, int min, int max)
//    {
//        if (min >= max)
//            return 0;

//        if(min + 1 == max)
//        {
//            if(arr[min] > arr[max])
//            {
//                swap(arr, min, max);
//                return 1;
//            }
//            return 0;
//        }

//        int mid = (min + max) / 2;

//        long leftOperations = mergeSort(arr, min, mid);
//        long rightOperations = mergeSort(arr, mid + 1, max);

//        int left = min;
//        int right = mid;

//        return rightOperations + leftOperations;
//    }
    
//    public static void swap(List<int> arr, int a, int b)
//    {
//        int temp = arr[a];
//        arr[a] = arr[b];
//        arr[b] = temp;
//    }
//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int t = Convert.ToInt32(Console.ReadLine().Trim());

//        for (int tItr = 0; tItr < t; tItr++)
//        {
//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//            long result = Result.countInversions(arr);

//            textWriter.WriteLine(result);
//        }

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
