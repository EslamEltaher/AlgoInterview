////23 https://www.hackerrank.com/challenges/minimum-swaps-2/problem

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

//    // Complete the minimumSwaps function below.
//    static int minimumSwaps(int[] arr)
//    {
//        int swaps = 0;
//        int[] indecies = new int[arr.Length];

//        for(int i = 0; i < arr.Length; i++)
//        {
//            indecies[arr[i] - 1] = i;
//        }

//        for(int i = 0; i < indecies.Length; i++)
//        {
//            if (indecies[i] == i)
//                continue;

//            //swapping
//            int currItem = arr[i];

//            arr[i] = i + 1;
//            arr[indecies[i]] = currItem;

//            indecies[currItem - 1] = indecies[i];
//            indecies[i] = i;

//            swaps++;
//        }

//        return swaps;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int res = minimumSwaps(arr);

//        textWriter.WriteLine(res);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
