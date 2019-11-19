////3

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

//    // Complete the jumpingOnClouds function below.
//    static int jumpingOnClouds(int[] c)
//    {
//        var numberOfJumps = 0;
//        for(int i = 0; i < c.Length; numberOfJumps++)
//        {
//            if ((i + 2 < c.Length) && c[i + 2] == 0)
//                i += 2;
//            else if (c[i + 1] == 0)
//                i += 1;

//            if (i == c.Length - 1) i = c.Length;
//        }
//        return numberOfJumps;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
//        ;
//        int result = jumpingOnClouds(c);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
