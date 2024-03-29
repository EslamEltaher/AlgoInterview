﻿////https://www.hackerrank.com/challenges/grid-challenge/problem
////greedy

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
//         * Complete the 'gridChallenge' function below.
//         *
//         * The function is expected to return a STRING.
//         * The function accepts STRING_ARRAY grid as parameter.
//         */

//        public static string gridChallenge(List<string> grid)
//        {
//            if (grid.Count == 1)
//                return "YES";

//            grid = grid.Select(s =>
//            {
//                var charArr = s.ToCharArray();
//                Array.Sort(charArr);
//                return string.Join("", charArr);
//            }).ToList();

//            for (int i = 1; i < grid.Count; i++)
//            {
//                var curr = grid[i];
//                var prev = grid[i - 1];

//                for (int j = 0; j < curr.Length; j++)
//                {
//                    if (curr[j] < prev[j])
//                        return "NO";
//                }
//            }
//            return "YES";
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
//                int n = Convert.ToInt32(Console.ReadLine().Trim());

//                List<string> grid = new List<string>();

//                for (int i = 0; i < n; i++)
//                {
//                    string gridItem = Console.ReadLine();
//                    grid.Add(gridItem);
//                }

//                string result = Result.gridChallenge(grid);

//                textWriter.WriteLine(result);
//            }

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}
