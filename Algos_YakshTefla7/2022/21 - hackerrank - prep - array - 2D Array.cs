////21 https://www.hackerrank.com/challenges/2d-array/problem

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
//     * Complete the 'hourglassSum' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
//     */

//    public static int hourglassSum(List<List<int>> arr)
//    {
//        //int[,] result = new int[arr.Count - 2, arr[0].Count - 2];

//        int max = int.MinValue;
//        for (int i = 0; i < arr.Count - 2; i++)
//        {
//            //result[i, 0] = 
//            //    arr[i][0] + arr[i][1] + arr[i][2]
//            //    + arr[i + 1][1]
//            //    + arr[i + 2][0] + arr[i + 2][1] + arr[i + 2][2];

//            //max = Math.Max(result[i, 0], max);
//            //Console.WriteLine(result[i,0]);

//            for (int j = 0; j < arr.Count - 2; j++)
//            {
//                int result = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
//                    + arr[i + 1][j + 1]
//                    + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

//                max = Math.Max(result, max);
//                //result[i, j] = result[i, j - 1]
//                //    - arr[i][j - 1] - arr[i + 2][j - 1] - arr[i + 1][j]
//                //    + arr[i][j]     + arr[i + 2][j + 1]     + arr[i + 1][j + 1];

//                //Console.WriteLine(result[i, j]);
//                //max = Math.Max(result[i, j], max);
//            }
//        }
//        return max;
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            List<List<int>> arr = new List<List<int>>();

//            for (int i = 0; i < 6; i++)
//            {
//                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//            }

//            int result = Result.hourglassSum(arr);    

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}