////25 https://www.hackerrank.com/challenges/magic-square-forming/problem






/////Misunderstood the problem description

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

//    // Complete the formingMagicSquare function below.
//    static int formingMagicSquare(int[][] s)
//    {
//        int[] sums = new int[4] {
//            s[0][0] + s[2][2],
//            s[0][1] + s[2][1],
//            s[1][0] + s[1][2],
//            s[2][0] + s[0][2]
//        };

//        Array.Sort(sums);
        

//        int sum = sums[0] + sums[1] + sums[2] + sums[3];

//        //if (sums[0] == sums[1] && sums[1] == sums[2]) ;




//        int avg = (int)Math.Round(sum / 4d);

//        if (sums[0] == sums[1])
//            avg = sums[0];

//        if (sums[1] == sums[2])
//            avg = sums[1];

//        if (sums[2] == sums[3])
//            avg = sums[2];


//        return Math.Abs(sums[0] - avg)
//            + Math.Abs(sums[1] - avg)
//            + Math.Abs(sums[2] - avg)
//            + Math.Abs(sums[3] - avg);
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int[][] s = new int[3][];

//        for (int i = 0; i < 3; i++)
//        {
//            s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
//        }

//        int result = formingMagicSquare(s);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
