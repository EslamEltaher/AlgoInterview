﻿////29 https://www.hackerrank.com/challenges/greedy-florist/problem

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

//    // Complete the getMinimumCost function below.
//    static int getMinimumCost(int k, int[] c)
//    {
//        int cost = 0;
//        Array.Sort(c);
//        c = c.Reverse().ToArray();

//        int m = 0;
//        for (int i = 0; i < c.Length; i++)
//        {
//            if (i % k == 0)
//                m++;

//            cost += m * c[i];
//        }

//        return cost;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nk = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nk[0]);

//        int k = Convert.ToInt32(nk[1]);

//        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
//        ;
//        int minimumCost = getMinimumCost(k, c);

//        textWriter.WriteLine(minimumCost);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
