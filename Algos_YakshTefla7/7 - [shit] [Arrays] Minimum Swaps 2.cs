////7 https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays

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

//        var newArr = new int[arr.Length];
//        for (int i = 0; i < arr.Length; i++)
//            newArr[i] = arr[i];

//        sort(newArr);

//        for(int i = 0; i < arr.Length; i++)
//        {
//            int x = newArr[i];
//            int j = indexOf(arr, x);

//            if(i != j)
//            {
//                swap(arr, i, j);
//                swaps++;
//            }
//        }

//        return swaps;
//    }

//    static int indexOf(int[] arr, int x)
//    {
//        int index = -1;

//        for (int i = 0; i < arr.Length; i++)
//            if (arr[i] == x) return i;

//        return index;
//    }

//    static void swap(int[] arr, int i, int j)
//    {
//        var temp = arr[i];
//        arr[i] = arr[j];
//        arr[j] = temp;
//    }

//    static void sort(int[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            for (int j = i; j < arr.Length; j++)
//            {
//                if (arr[j] < arr[i])
//                {
//                    swap(arr, i, j);
//                    j = arr.Length;
//                }
//            }
//        }
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
