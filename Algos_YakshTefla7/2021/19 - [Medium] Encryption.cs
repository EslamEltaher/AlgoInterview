////https://www.hackerrank.com/challenges/encryption/problem

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
//         * Complete the 'encryption' function below.
//         *
//         * The function is expected to return a STRING.
//         * The function accepts STRING s as parameter.
//         */

//        public static string encryption(string s)
//        {
//            s = s.Replace(" ","");


//            //chillout
//            int l = s.Length;
//            double sqrt = Math.Sqrt(l);

//            //2
//            //3
//            int floor = (int)Math.Floor(sqrt);
//            int ceil = (int)Math.Ceiling(sqrt);

//            int row = floor;
//            int col = floor;

//            if(floor != ceil)
//            {
//                if(row * col < l)
//                {
//                    col++;
//                    if (row * col < l)
//                        row++;
//                }
//            }

//            string result = "";
//            int spaces = (row * col) - l;
//            //hell
//            //owor
//            //ld

//            //hel
//            //low
//            //orl

//            //3, 3
//            //chi
//            //llo
//            //ut

//            for (int i = 0; i < s.Length + spaces; i++)
//            {
//                int index = (i % row) * col + (i / row);
//                if (i % row == 0 && i != 0)
//                    result += " ";
//                if (index < s.Length)
//                    result += s[index];
//            }

//            return result;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            string s = Console.ReadLine();

//            string result = Result.encryption(s);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
