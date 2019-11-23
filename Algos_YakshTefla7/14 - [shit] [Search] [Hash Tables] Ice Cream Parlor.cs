////14 https://www.hackerrank.com/challenges/ctci-ice-cream-parlor/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=search

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

//    // Complete the whatFlavors function below.
//    static void whatFlavors(int[] cost, int money)
//    {
//        int flavorsCount = 0;
//        //int[][] flavors = new int[cost.Length][];
//        Dictionary<int, int[]> flavors = new Dictionary<int, int[]>();

//        for (int i = 0; i < cost.Length; i++)
//        {
//            if(cost[i] < money)
//            {
//                if(flavors.ContainsKey(cost[i]))
//                {
//                    int[] flavor = flavors[cost[i]];
//                    flavor[flavor.Length]
//                }
//                else
//                {

//                }
//                //flavors[flavorsCount][0] = cost[i];
//                //flavors[flavorsCount][1] = i + 1;
//                flavorsCount++;
//            }



//        }
//    }



//    static void Main(string[] args)
//    {
//        int t = Convert.ToInt32(Console.ReadLine());

//        for (int tItr = 0; tItr < t; tItr++)
//        {
//            int money = Convert.ToInt32(Console.ReadLine());

//            int n = Convert.ToInt32(Console.ReadLine());

//            int[] cost = Array.ConvertAll(Console.ReadLine().Split(' '), costTemp => Convert.ToInt32(costTemp))
//            ;
//            whatFlavors(cost, money);
//        }
//    }
//}
