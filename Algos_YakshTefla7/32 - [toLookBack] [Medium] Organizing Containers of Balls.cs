////32 https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem

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

//    // Complete the organizingContainers function below.
//    static string organizingContainers(int[][] container)
//    {
//        //if every container has a number of (not needed balls) that is equal to (the number of needed balls it misses)
//        int length = container.Length;

//        bool possible = false;

//        int[] sumsOfBalls = new int[length];
//        int[] containerSums = new int[length];
//        bool[] ballTaken = new bool[length];
//        for (int i = 0; i < length; i++)
//        {
//            for (int j = 0; j < length; j++)
//            {
//                containerSums[i] += container[i][j];
//                sumsOfBalls[j] += container[i][j];
//            }
//        }

//        for (int i = 0; i < length; i++)
//        {
//            possible = false;
//            for (int j = 0; j < length; j++)
//            {
//                //if what the container has of this ball  == the total balls it's missing of thils ball
//                if (containerSums[i] - container[i][j] == sumsOfBalls[j] - container[i][j] && ballTaken[j] == false)
//                {
//                    ballTaken[j] = true;
//                    possible = true;
//                    break;
//                }
//            }
//            if (!possible) return "Impossible";
//        }

//        return possible ? "Possible" : "Impossible";
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int q = Convert.ToInt32(Console.ReadLine());

//        for (int qItr = 0; qItr < q; qItr++)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
                
//            int[][] container = new int[n][];

//            for (int i = 0; i < n; i++)
//            {
//                container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
//            }

//            string result = organizingContainers(container);

//            textWriter.WriteLine(result);
//        }

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
