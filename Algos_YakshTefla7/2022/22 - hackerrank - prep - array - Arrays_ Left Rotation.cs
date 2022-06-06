﻿////22 https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem

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
//     * Complete the 'rotLeft' function below.
//     *
//     * The function is expected to return an INTEGER_ARRAY.
//     * The function accepts following parameters:
//     *  1. INTEGER_ARRAY a
//     *  2. INTEGER d
//     */

//    public static List<int> rotLeft(List<int> a, int d)
//    {
//        int n = a.Count;

//        d %= n;

//        List<int> result = new List<int>();

//        for (int i = 0; i < n; i++)
//        {
//            result.Add(a[(i + d) % n]);
//        }

//        return result;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//        int n = Convert.ToInt32(firstMultipleInput[0]);

//        int d = Convert.ToInt32(firstMultipleInput[1]);

//        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//        List<int> result = Result.rotLeft(a, d);

//        textWriter.WriteLine(String.Join(" ", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
