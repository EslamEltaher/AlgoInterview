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

//    // Complete the cutTheSticks function below.
//    static int[] cutTheSticks(int[] arr)
//    {
//        var sticks = new int[arr.Length];
//        sticks[0] = arr.Length;

//        var n = 1;

//        Array.Sort(arr);

//        //last iteration shouldn't be mentioned so
//        for (int i = 0; i < arr.Length - 1; i++)
//        {
//            if (i < arr.Length - 1 && arr[i + 1] == arr[i])
//                continue;

//            sticks[n++] = arr.Length - i - 1;
//        }

//        return sticks.Where((el, i) => i < n).ToArray();


//        //var solution = new int[n];
//        //for (int i = 0; i < n; i++)
//        //    solution[i] = sticks[i];

//        //return solution;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int[] result = cutTheSticks(arr);

//        textWriter.WriteLine(string.Join("\n", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
