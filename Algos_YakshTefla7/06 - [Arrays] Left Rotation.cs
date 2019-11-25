////6 https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays

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

//    // Complete the rotLeft function below.
//    static int[] rotLeft(int[] a, int d)
//    {
//        int n = a.Length;

//        d = d % n;

//        if (d == 0)
//            return a;

//        int[] temp = new int[d];

//        for(int i = 0; i < d; i++)
//            temp[i] = a[i];


//        for(int i = 0; i < n - d; i++)
//        {
//            a[i] = a[i + d];
//        }

//        for (int i = n-d; i < n; i++)
//        {
//            a[i] = temp[i - n + d];
//        }
//        return a;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nd = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nd[0]);

//        int d = Convert.ToInt32(nd[1]);

//        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
//        ;
//        int[] result = rotLeft(a, d);

//        textWriter.WriteLine(string.Join(" ", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
