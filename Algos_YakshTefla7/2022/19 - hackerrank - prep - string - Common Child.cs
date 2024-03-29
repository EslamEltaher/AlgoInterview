﻿////19 https://www.hackerrank.com/challenges/common-child/problem

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
//     * Complete the 'commonChild' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts following parameters:
//     *  1. STRING s1
//     *  2. STRING s2
//     */

//    public static int commonChild(string s1, string s2)
//    {
//        int[][] chars = new int[s1.Length][];


//        for(int i = 0; i < s1.Length; i++)
//        {
//            chars[i] = new int[s2.Length];
//            chars[i][0] = s1[i] == s2[0]  ? 1 : 0;

//            for(int j = 1; j < s2.Length; j++)
//            {
//                int sameChar = 0;
//                if(s1[i] == s2[j])
//                    sameChar = 1;

//                chars[i][j] = Math.Max(sameChar, chars[i][j - 1]);

//                if (i > 0)
//                {
//                    chars[i][j] = Math.Max(chars[i][j], sameChar + chars[i - 1][j - 1]);
//                    chars[i][j] = Math.Max(chars[i][j], chars[i - 1][j]);
//                }
//            }
//        }

//        return chars[s1.Length - 1][s2.Length - 1];
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s1 = Console.ReadLine();

//        string s2 = Console.ReadLine();

//        int result = Result.commonChild(s1, s2);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
