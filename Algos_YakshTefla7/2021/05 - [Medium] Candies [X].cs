////https://www.hackerrank.com/challenges/candies/problem
////greedy
///

//XXXXX

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
//         * Complete the 'candies' function below.
//         *
//         * The function is expected to return a LONG_INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER n
//         *  2. INTEGER_ARRAY arr
//         */

//        public static long candies(int n, List<int> arr)
//        {
//            if (arr.Count == 1)
//                return 1;
//            if (arr.Count == 2)
//                return 3;

//            long candies = 0;

//            int[] transitions = new int[n];

//            transitions[0] = (arr[1] > arr[0]) ? 1 : 0;

//            for (int i = 1; i < n; i++)
//            {
//                if (arr[i] > arr[i - 1])
//                {
//                    transitions[i] = 1;
//                }
//                else if (arr[i] == arr[i - 1])
//                {
//                    transitions[i] = 0;
//                }
//                else
//                {
//                    transitions[i] = -1;
//                }
//            }



//            int currentStreak;

//            if (transitions[1] == 0)
//            {
//                candies = 2;
//                currentStreak = 1;
//            }
//            else if(transitions[1] == -1)
//            {
//                candies = 3;
//                currentStreak = 2;
//            }
//            else
//            {
//                candies = 3;
//                currentStreak = 2;
//            }


//            for (int i = 2; i < n; i++)
//            {
//                if (transitions[i] == 0)
//                {
//                    currentStreak = 1;
//                }
//                else if (transitions[i] > transitions[i - 1]) //from -1 to 1
//                {
//                    currentStreak = 2;
//                }
//                else if (transitions[i] == transitions[i - 1]) //from -1 to -1  OR from 1 to 1
//                {
//                    currentStreak++;
//                }  
//                else
//                {
//                    currentStreak = 1;
//                }

//                candies += currentStreak;

//            }
//            //int current = transitions[0] == 1 ? 1 : 2;
//            //candies = current;
//            //for (int i = 1; i < n; i++)
//            //{
//            //    if (transitions[i] == 0 && current == 1)
//            //        current = 2;
//            //    else if (transitions[i] == 0)
//            //        current--;
//            //    else if (transitions[i] == 1)
//            //        current++;
//            //    else
//            //        current--;

//            //    candies += current;
//            //}

//            return candies;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = new List<int>();

//            for (int i = 0; i < n; i++)
//            {
//                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
//                arr.Add(arrItem);
//            }

//            long result = Result.candies(n, arr);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
