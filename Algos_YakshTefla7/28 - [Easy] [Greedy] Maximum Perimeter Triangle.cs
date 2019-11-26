////28 https://www.hackerrank.com/challenges/maximum-perimeter-triangle/problem

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

//    // Complete the maximumPerimeterTriangle function below.
//    static int[] maximumPerimeterTriangle(int[] sticks)
//    {
//        int[] result = new int[] { -1 };

//        Array.Sort(sticks);
//        sticks = sticks.Reverse().ToArray();

//        for (int i = 0; i < sticks.Length - 2; i++)
//        {
//            if (sticks[i] < sticks[i + 1] + sticks[i + 2])
//            {
//                result = new int[] { sticks[i + 2], sticks[i + 1], sticks[i] };
//                break;
//            }
//        }

//        return result;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] sticks = Array.ConvertAll(Console.ReadLine().Split(' '), sticksTemp => Convert.ToInt32(sticksTemp))
//        ;
//        int[] result = maximumPerimeterTriangle(sticks);

//        textWriter.WriteLine(string.Join(" ", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
