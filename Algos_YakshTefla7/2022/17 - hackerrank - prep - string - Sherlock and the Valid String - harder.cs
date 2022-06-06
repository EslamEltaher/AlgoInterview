////17 https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem

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
//     * Complete the 'isValid' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts STRING s as parameter.
//     */

//    public static string isValid(string s)
//    {
//        if (s.Length <= 1)
//            return "YES";

//        int[] chars = new int[26];

//        for(int i = 0; i < s.Length; i++)
//        {
//            chars[s[i] - 'a']++;
//        }

//        Array.Sort(chars);

//        bool usedExtraChar = false;

//        int last = chars[chars.Length - 1];
//        int beforeLast = chars[chars.Length - 2];

//        int num = last;

//        if (beforeLast == 1 && last > 2)
//        {
//            chars[chars.Length - 2] = 0;
//            num = 0;
//            usedExtraChar = true;
//        }

//        else if(last - beforeLast == 1)
//        {
//            num = beforeLast;
//            usedExtraChar = true;
//        }

//        else if (last - beforeLast > 1)
//            return "NO";

//        for (int i = chars.Length - 2; i >= 0; i--)
//        {
//            if (chars[i] == 0 || chars[i] == num)
//                continue;

//            if (usedExtraChar || chars[i] != 1)
//                return "NO";

//            usedExtraChar = true;

//            //if (chars[i] == chars[i - 1] || chars[i] == 0)
//            //    continue;

//            //if(chars[i - 1] == 0)
//            //{
//            //    continue;
//            //}

//            //if (chars[i] - chars[i - 1] > 1)
//            //    return "NO";

//            //if (usedExtraChar)
//            //    return "NO";

//            //usedExtraChar = true;
//        }

//        return "YES";
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s = Console.ReadLine();

//        string result = Result.isValid(s);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
