////12 https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms

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

//class Solution
//{

//    // Complete the minimumAbsoluteDifference function below.
//    static int minimumAbsoluteDifference(int[] arr)
//    {
//        Array.Sort(arr);
//        var minAbs = Math.Abs(arr[0] - arr[1]);

//        for(int i = 2; i < arr.Length; i++)
//        {
//            if (Math.Abs(arr[i] - arr[i - 1]) < minAbs)
//                minAbs = arr[i] - arr[i - 1];
//            if (minAbs == 0)
//                return 0;
//        }
//        return minAbs;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int result = minimumAbsoluteDifference(arr);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
