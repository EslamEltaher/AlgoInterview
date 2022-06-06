﻿////26 https://www.hackerrank.com/challenges/mark-and-toys/problem

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
//     * Complete the 'maximumToys' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts following parameters:
//     *  1. INTEGER_ARRAY prices
//     *  2. INTEGER k
//     */

//    public static int maximumToys(List<int> prices, int k)
//    {
//        var p = prices.ToArray();
//        Array.Sort(p);

//        int count = 0;

//        for(int i = 0; i < p.Length; i++)
//        {
//            if (p[i] > k)
//                break;

//            k -= p[i];
//            count++;
//        }

//        return count;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//        int n = Convert.ToInt32(firstMultipleInput[0]);

//        int k = Convert.ToInt32(firstMultipleInput[1]);

//        List<int> prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();

//        int result = Result.maximumToys(prices, k);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
