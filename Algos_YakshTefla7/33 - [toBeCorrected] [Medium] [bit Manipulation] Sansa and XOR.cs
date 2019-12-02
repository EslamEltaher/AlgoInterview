////33 https://www.hackerrank.com/challenges/sansa-and-xor/problem
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

//    // Complete the sansaXor function below.
//    static int sansaXor(int[] arr)
//    {
//        int length = arr.Length;
//        int[] arrOp = new int[length];

//        int op = length - 2;

//        if (length <= 2)
//            return 0;

//        int result = 0;
//        for (int i = 0; i < length; i++)
//        {
//            //min distance
//            arrOp[i] = Math.Min(length - i, 1 + i) * op;
//        }

//        for (int i = 0; i < arr.Length; i++)
//            result ^= (arrOp[i] % 2 == 1 ? (arr[i]) : 0);

//        return result;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int t = Convert.ToInt32(Console.ReadLine());

//        for (int tItr = 0; tItr < t; tItr++)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//            ;
//            int result = sansaXor(arr);

//            textWriter.WriteLine(result);
//        }

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
