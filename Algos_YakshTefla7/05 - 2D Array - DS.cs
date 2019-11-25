////5 https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays

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

//    // Complete the hourglassSum function below.
//    static int hourglassSum(int[][] arr)
//    {
//        int maxhourGlass = int.MinValue;

//        for (int i = 0; i < arr.Length - 2; i++)
//        {
//            for (int j = 1; j < arr[i].Length - 1; j++)
//            {
//                int hourGlass = arr[i][j - 1] + arr[i][j] + arr[i][j + 1]
//                                + arr[i + 1][j]
//                    + arr[i + 2][j - 1] + arr[i + 2][j] + arr[i + 2][j + 1];

//                maxhourGlass = maxhourGlass > hourGlass ? maxhourGlass : hourGlass;
//            }
//        }

//        return maxhourGlass;

//        //if (arr.Length < 3 || arr[0].Length < 3)
//        //    return 0;

//        //int[][] sums = new int[arr.Length][];

//        //for (int i = 0; i < arr.Length; i++)
//        //{
//        //    sums[i] = new int[arr[i].Length - 2];
//        //    for (int j = 1; j < arr[i].Length - 1; j++)
//        //    {
//        //        sums[i][j - 1] = arr[i][j - 1] + arr[i][j] + arr[i][j + 1];
//        //    }
//        //}

//        //for (int i = 1; i < arr.Length - 1; i++)
//        //{
//        //    for(int j = 0; j < arr[i].Length - 2; j++)
//        //    {
//        //        int hourGlass = sums[i - 1][j] + sums[i + 1][j] + arr[i][j + 1];
//        //        maxhourGlass = maxhourGlass > hourGlass ? maxhourGlass : hourGlass;
//        //    }
//        //}


//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int[][] arr = new int[6][];

//        for (int i = 0; i < 6; i++)
//        {
//            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
//        }

//        int result = hourglassSum(arr);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
