////13 https://www.hackerrank.com/challenges/count-triplets-1/problem

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

//    // Complete the countTriplets function below.
//    static long countTriplets(List<long> arr, long r)
//    {
//        long count = 0;

//        #region Brute Force
//        //for(int i = 0; i < arr.Count - 2; i++)
//        //{
//        //    for(int j = i + 1; j < arr.Count - 1; j++)
//        //    {
//        //        if(arr[j] == r * arr[i])
//        //        {
//        //            for(int k = j +1; k < arr.Count; k++)
//        //            {
//        //                if (arr[k] == r * arr[j])
//        //                    count++;
//        //            }
//        //        }
//        //    }
//        //}
//        #endregion

//        Dictionary<long, long> baseD = new Dictionary<long, long>();
//        Dictionary<long, long> pow1 = new Dictionary<long, long>();
//        Dictionary<long, long> pow2 = new Dictionary<long, long>();



//        for (int i = arr.Count - 1; i >= 0; i--)
//        {
//            //base
//            //if (!baseD.ContainsKey(arr[i]))
//            //    baseD.Add(arr[i], 0);

//            if (pow1.ContainsKey(arr[i]))
//                count += pow1[arr[i]];

//            //pow1
//            var baseNum = (arr[i] / r);
//            if (baseNum * r == arr[i])
//            {
//                if (!pow1.ContainsKey(baseNum))
//                    pow1.Add(baseNum, 0);

//                if (pow2.ContainsKey(baseNum))
//                    pow1[baseNum] += pow2[baseNum];
//            }

//            //pow2
//            baseNum = (arr[i] / r) / r;

//            if (baseNum * r * r == arr[i])
//            {
//                if(!pow2.ContainsKey(baseNum))
//                    pow2.Add(baseNum, 0);

//                pow2[baseNum]++;
//            }

//        }

//        return count;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nr = Console.ReadLine().TrimEnd().Split(' ');

//        int n = Convert.ToInt32(nr[0]);

//        long r = Convert.ToInt64(nr[1]);

//        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

//        long ans = countTriplets(arr, r);

//        textWriter.WriteLine(ans);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
