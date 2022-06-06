////16 https://www.hackerrank.com/challenges/ctci-making-anagrams/problem

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
//     * Complete the 'makeAnagram' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts following parameters:
//     *  1. STRING a
//     *  2. STRING b
//     */

//    public static int makeAnagram(string a, string b)
//    {
//        int[,] chars = new int[2, 26];

//        for(int i = 0; i < a.Length; i++)
//        {
//            chars[0, a[i] - 'a']++;
//        }

//        for (int i = 0; i < b.Length; i++)
//        {
//            chars[1, b[i] - 'a']++;
//        }


//        int count = 0;
//        for(int i = 0; i < 26; i++)
//        {
//            count += Math.Abs(chars[0, i] - chars[1, i]);
//        }
//        return count;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string a = Console.ReadLine();

//        string b = Console.ReadLine();

//        int res = Result.makeAnagram(a, b);

//        textWriter.WriteLine(res);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
