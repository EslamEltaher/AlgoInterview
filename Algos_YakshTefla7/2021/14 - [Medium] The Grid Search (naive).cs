////https://www.hackerrank.com/challenges/the-grid-search/problem

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
//         * Complete the 'gridSearch' function below.
//         *
//         * The function is expected to return a STRING.
//         * The function accepts following parameters:
//         *  1. STRING_ARRAY G
//         *  2. STRING_ARRAY P
//         */

//        public static string gridSearch(List<string> G, List<string> P)
//        {
//            int R = G.Count();
//            int C = G[0].Length;

//            int r = P.Count();
//            int c = P[0].Length;

//            for (int i = 0; i <= R - r; i++)
//            {
//                for (int j = 0; j <= C - c; j++)
//                {
//                    if (G[i][j] == P[0][0])
//                    {
//                        bool equal = true;
//                        for (int ii = 0; ii < r; ii++)
//                        {
//                            for (int jj = 00; jj < c; jj++)
//                            {
//                                if (G[i + ii][j + jj] != P[ii][jj])
//                                    equal = false; ;
//                            }
//                            if (!equal)
//                                ii = r;
//                        }

//                        if (equal)
//                            return "YES";
//                    }
//                }
//            }
//            return "NO";
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int t = Convert.ToInt32(Console.ReadLine().Trim());

//            for (int tItr = 0; tItr < t; tItr++)
//            {
//                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//                int R = Convert.ToInt32(firstMultipleInput[0]);

//                int C = Convert.ToInt32(firstMultipleInput[1]);

//                List<string> G = new List<string>();

//                for (int i = 0; i < R; i++)
//                {
//                    string GItem = Console.ReadLine();
//                    G.Add(GItem);
//                }

//                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//                int r = Convert.ToInt32(secondMultipleInput[0]);

//                int c = Convert.ToInt32(secondMultipleInput[1]);

//                List<string> P = new List<string>();

//                for (int i = 0; i < r; i++)
//                {
//                    string PItem = Console.ReadLine();
//                    P.Add(PItem);
//                }

//                string result = Result.gridSearch(G, P);

//                textWriter.WriteLine(result);
//            }

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
