//https://www.hackerrank.com/challenges/bigger-is-greater/editorial

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
//         * Complete the 'biggerIsGreater' function below.
//         *
//         * The function is expected to return a STRING.
//         * The function accepts STRING w as parameter.
//         */

//        public static string biggerIsGreater(string w)
//        {
//            char[] chars = w.ToArray();
//            int i = 0;
//            for(i = chars.Length - 1; i > 0; i--)
//            {
//                if (chars[i] > chars[i - 1])
//                {
//                    int min = i;
//                    //get the min next
//                    for(int j = i; j < chars.Length; j++)
//                    {
//                        if (chars[j] < chars[min] && chars[j] > chars[i - 1])
//                            min = j;
//                    }
//                    char temp = chars[min];
//                    chars[min] = chars[i - 1];
//                    chars[i - 1] = temp;

//                    break;
//                }
//            }

//            //if not done
//            if(i != 0)
//                //sort the rest
//                Array.Sort(chars, i, chars.Length - i);

//            string result = string.Join("", chars);

//            if (result == w)
//                result = "no answer";

//            return result;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int T = Convert.ToInt32(Console.ReadLine().Trim());

//            for (int TItr = 0; TItr < T; TItr++)
//            {
//                string w = Console.ReadLine();

//                string result = Result.biggerIsGreater(w);

//                textWriter.WriteLine(result);
//            }

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
