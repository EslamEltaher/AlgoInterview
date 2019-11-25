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

//    // Complete the sockMerchant function below.
//    static int sockMerchant(int n, int[] ar)
//    {
//        //int[,] colors = new int[n, 2];
//        int[] colors = new int[100];
//        for (int i = 0; i < n; i++)
//        {
//            colors[ar[i]]++;
//        }

//        int pairs = 0;
//        for(int i = 0; i < 100; i++)
//        {
//            pairs += colors[i] / 2;
//        }
//        return pairs;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
//        ;
//        int result = sockMerchant(n, ar);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
