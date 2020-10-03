////30 https://www.hackerrank.com/challenges/pylons/problem

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

//    // Complete the pylons function below.
//    static int pylons(int k, int[] arr)
//    {
//        //6 2
//        //0 1 1 1 1 0
//        int count = 0;
//        for(int i = 0; i < arr.Length; i+= k)
//        {
//            int farthest = Math.Min(i + k - 1, arr.Length - 1);

//            int next;

//            for(next = farthest; next > (i - k) && next > 0; next--)
//            {
//                if (arr[next] == 1)
//                {
//                    count++;
//                    break;
//                }
//            }

//            if (next == i - k)
//                return -1;
//            else
//                i = next;
//        }

//        return count;
//    }

//    static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nk = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nk[0]);

//        int k = Convert.ToInt32(nk[1]);

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int result = pylons(k, arr);


//        //Console.WriteLine(result);
//        //Console.ReadLine();
//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}
