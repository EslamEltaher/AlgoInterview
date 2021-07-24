////https://www.hackerrank.com/challenges/3d-surface-area/problem

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

//namespace Algos_YakshTefla7._2021
//{

//    class Result
//    {

//        /*
//         * Complete the 'surfaceArea' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts 2D_INTEGER_ARRAY A as parameter.
//         */

//        public static int surfaceArea(List<List<int>> A)
//        {
//            int result = 0;
//            int H = A.Count;
//            int W = A[0].Count;
//            for (int i = 0; i < H; i++)
//            {
//                for (int j = 0; j < W; j++)
//                {
//                    result += 6 * A[i][j] - (2 * (A[i][j] - 1));

//                    int H_1 = 0;
//                    int W_1 = 0;
//                    if (i > 0)
//                    {
//                        H_1 = A[i - 1][j];
//                        if (H_1 > A[i][j])
//                            H_1 = A[i][j];
//                    }
//                    if(j > 0)
//                    {
//                        W_1 = A[i][j - 1];
//                        if (W_1 > A[i][j])
//                            W_1 = A[i][j];
//                    }

//                    result -= 2 * H_1;
//                    result -= 2 * W_1;
//                }
//            }

//            return result;
//        }
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int H = Convert.ToInt32(firstMultipleInput[0]);

//            int W = Convert.ToInt32(firstMultipleInput[1]);

//            List<List<int>> A = new List<List<int>>();

//            for (int i = 0; i < H; i++)
//            {
//                A.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList());
//            }

//            int result = Result.surfaceArea(A);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
