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
//        int cost = 0;
//        for (int i = 0; i < arr.Length;)
//        {
//            int cityIndex = -1;
//            int startPos = i + (k - 1);     //k-1 = coverage
            
//            //startPos = startPos > arr.Length - 1 ? arr.Length - 1 : startPos;
//            startPos = Math.Min(startPos, arr.Length - 1);

//            //inspect farthest city until current city
//            for (int j = startPos; j >= i; j--)
//            {
//                if(arr[j] == 1)
//                {
//                    cityIndex = j;
//                    cost++;
//                    break;
//                }
//            }
//            //one last chance
//            // Checking cities on the reverse direction
//            if (cityIndex == -1)
//            {
//                //startPost
//                startPos = i - 1;
//                int endPos = i - (k - 1);

//                endPos = Math.Max(0, endPos);

//                for (int j = startPos; j >= endPos; j--)
//                {
//                    if (arr[j] == 1)
//                    {
//                        cityIndex = j;
//                        cost++;
//                        break;
//                    }
//                }
//            }

//            if (cityIndex == -1)
//                return -1;

//            i = cityIndex + k;  //after city coverage
//        }
//        return cost;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nk = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nk[0]);

//        int k = Convert.ToInt32(nk[1]);

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int result = pylons(k, arr);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
