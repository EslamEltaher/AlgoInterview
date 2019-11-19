////1

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
//        int[,] colors = new int[n, 2];
//        int cIndex = 0;
//        for (int i = 0; i < n; i++)
//        {
//            bool exists = false;
//            for (int j = 0; j < cIndex; j++)
//            {
//                if (colors[j, 0] == ar[i])
//                {
//                    colors[j, 1]++;
//                    exists = true;
//                    j = cIndex;
//                }
//            }
//            if (!exists)
//            {
//                colors[cIndex, 0] = ar[i];
//                colors[cIndex, 1] = 1;
//                cIndex++;
//            }
//        }

//        int pairs = 0;
//        for (int i = 0; i < cIndex; i++)
//        {
//            if (colors[i, 0] == 0)
//            {
//                return pairs;
//            }
//            pairs += colors[i, 1] / 2;
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
