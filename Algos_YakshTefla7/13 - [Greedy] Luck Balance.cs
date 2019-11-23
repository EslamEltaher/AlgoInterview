////13 https://www.hackerrank.com/challenges/luck-balance/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms&h_r=next-challenge&h_v=zen

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

//    // Complete the luckBalance function below.
//    static int luckBalance(int k, int[][] contests)
//    {
//        int luck = 0;

//        int[] importantOnly = new int[contests.Length];
//        int importantCount = 0;

//        for(int i = 0; i < contests.Length; i++)
//        {
//            if(contests[i][1] == 0)
//                luck += contests[i][0];
//            else
//                importantOnly[importantCount++] = contests[i][0];
//        }

//        Array.Sort(importantOnly);

//        for (int i = importantOnly.Length - 1; i > importantOnly.Length - importantCount - 1; i--)
//        {
//            if(k > 0)
//            {
//                luck += importantOnly[i];
//                k--;
//            }
//            else
//            {
//                luck -= importantOnly[i];
//            }
//        }

//        return luck;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nk = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nk[0]);

//        int k = Convert.ToInt32(nk[1]);

//        int[][] contests = new int[n][];

//        for (int i = 0; i < n; i++)
//        {
//            contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
//        }

//        int result = luckBalance(k, contests);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
