////https://www.hackerrank.com/challenges/minimum-loss/problem

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
//         * Complete the 'minimumLoss' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts LONG_INTEGER_ARRAY price as parameter.
//         */

//        public static int minimumLoss(List<long> price)
//        {
//            long[] p = price.ToArray();
//            if (price.Count <= 2)
//                return (int)(p[1] - p[0]);


//            Dictionary<long, long> indexes = new Dictionary<long, long>();
//            for (int i = 0; i < price.Count; i++)
//            {
//                indexes[price[i]] = i;
//            }

//            Array.Sort(p);
//            int min = (int)(p[1] - p[0]);

//            for (int i = 2; i < price.Count; i++)
//            {
//                if (p[i] - p[i - 1] < min && indexes[p[i]] < indexes[p[i - 1]])
//                    min = (int)(p[i] - p[i - 1]);
//            }

//            return min;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<long> price = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(priceTemp => Convert.ToInt64(priceTemp)).ToList();

//            int result = Result.minimumLoss(price);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
