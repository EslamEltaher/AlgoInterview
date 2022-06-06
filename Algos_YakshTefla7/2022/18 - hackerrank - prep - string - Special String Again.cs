////18 https://www.hackerrank.com/challenges/special-palindrome-again/problem

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

//class Solution
//{

//    // Complete the substrCount function below.
//    static long substrCount(int n, string s)
//    {
//        int count = 0;

//        for (int i = 0; i < n; i++)
//        {
//            int charCount = 0;

//            for(int j = i; j < n; j++) {
//                if (s[j] == s[i])
//                    charCount++;
//                else
//                    break;
//                //bool rightSide = false;

//                //if (!rightSide)
//                //{
//                //    if (s[j] == c)
//                //        count++;
//                //    else
//                //    {
//                //        rightSide = true;

//                //    }
//                //}
//                //else
//                //{

//                //}
//            }
//            count += charCount;

//            int rSideCount = 0;
//            for(int j = i + (charCount + 1); j < n && j <= i + 2 * charCount; j++) {
//                //if (i + (2 * charCount) < n - 1) {
//                if (s[j] == s[i])
//                    rSideCount++;
//                else break;
//            }

//            if (rSideCount == charCount)
//                count++;

//        }

//        //char currentChar = s[0];
//        //int charCount = 1;
//        //bool rightSide = false;

//        //for(int i = 1; i < s.Length; i++)
//        //{
//        //    if (!rightSide)
//        //    {
//        //        if (s[i] == currentChar)
//        //        {
//        //            count += charCount;
//        //            charCount++;
//        //        }
//        //    }
//        //    else
//        //    {
//        //        if(s[i] == currentChar)
//        //        {
//        //            count++;
//        //            charCount--;
//        //        }
//        //    }
//        //}

//        //count += n;

//        return count;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        string s = Console.ReadLine();

//        long result = substrCount(n, s);

//        textWriter.WriteLine(result);

//        textWriter.Flush();     
//        textWriter.Close();
//    }
//}
