////4

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

//    // Complete the equalizeArray function below.
//    static int equalizeArray(int[] arr)
//    {
//        var n = arr.Length;

//        int[,] numbers = new int[n, 2];

//        int numIndex = 0;

//        for (int i = 0; i < n; i++)
//        {
//            bool exists = false;
//            for (int j = 0; j < numIndex; j++)
//            {
//                if (numbers[j, 0] == arr[i])
//                {
//                    numbers[j, 1]++;
//                    j = numIndex;
//                }
//            }

//            if (!exists)
//            {
//                numbers[numIndex, 0] = arr[i];
//                numbers[numIndex, 1] = 1;
//                numIndex++;
//            }
//        }

//        int max = 0;
//        for (int i = 0; i < numIndex; i++)
//        {
//            if (numbers[i, 1] > max) max = numbers[i, 1];
//        }
//        return n - max;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int result = equalizeArray(arr);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
