////https://www.hackerrank.com/challenges/the-time-in-words/problem

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algos_YakshTefla7._2021
//{
//    using System.CodeDom.Compiler;
//    using System.Collections.Generic;
//    using System.Collections;
//    using System.ComponentModel;
//    using System.Diagnostics.CodeAnalysis;
//    using System.Globalization;
//    using System.IO;
//    using System.Linq;
//    using System.Reflection;
//    using System.Runtime.Serialization;
//    using System.Text.RegularExpressions;
//    using System.Text;
//    using System;

//    class Result
//    {

//        /*
//         * Complete the 'timeInWords' function below.
//         *
//         * The function is expected to return a STRING.
//         * The function accepts following parameters:
//         *  1. INTEGER h
//         *  2. INTEGER m
//         */

//        public static string[] numbers =
//            {
//            "",
//            "one",
//            "two",
//            "three",
//            "four",
//            "five",
//            "six",
//            "seven",
//            "eight",
//            "nine",
//            "ten",
//            "eleven",
//            "twelve",
//            "thirteen",
//            "fourteen",
//            "quarter",
//            "sixteen",
//            "seventeen",
//            "eighteen",
//            "nineteen",
//            "twenty",
//            "twenty one",
//            "twenty two",
//            "twenty three",
//            "twenty four",
//            "twenty five",
//            "twenty six",
//            "twenty seven",
//            "twenty eight",
//            "twenty nine",
//            "half"
//            };
//        public static string timeInWords(int h, int m)
//        {
//            if (m == 0)
//                return numbers[h] + " o' clock";

//            string separator = m > 30 ? "to" : "past";
//            if (m > 30)
//            {
//                m = 60 - m;
//                h = (h + 1) % 12;
//            }


//            return numbers[m] + (m == 15 || m == 30 ? "" : m > 1 ? " minutes" : " minute") + " " + separator + " " + numbers[h];
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int h = Convert.ToInt32(Console.ReadLine().Trim());

//            int m = Convert.ToInt32(Console.ReadLine().Trim());

//            string result = Result.timeInWords(h, m);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
