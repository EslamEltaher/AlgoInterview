////https://www.hackerrank.com/challenges/almost-sorted/problem    

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


//namespace Algos_YakshTefla7._2021
//{

//    class Result
//    {

//        /*
//         * Complete the 'almostSorted' function below.
//         *
//         * The function accepts INTEGER_ARRAY arr as parameter.
//         */

//        public static void almostSorted(List<int> arr)
//        {
//            int swapL = -1, swapR = -1;
//            int revStart = -1, revEnd = -1;

//            for (int i = 1; i < arr.Count; i++)
//            {
//                ////////////// Reverse
//                if (arr[i] < arr[i - 1])
//                {
//                    if (revStart == -1)
//                    {
//                        revStart = i - 1;
//                    }
//                    else if (revEnd != -1)
//                    {
//                        revEnd = 0; // to signal that it needs more than one reverse
//                    }
//                }
//                else if (arr[i] > arr[i - 1])
//                {
//                    if (revStart != -1 && revEnd == -1)
//                    {
//                        revEnd = i - 1;
//                    }
//                }


//                ////SWAP
//                if (arr[i] < arr[i - 1])
//                {
//                    if (swapL == -1)
//                    {
//                        swapL = i;
//                    }
//                    else
//                    {
//                        if (swapR == -1)
//                        {
//                            swapR = i;

//                            //edge case (if swapR is smaller than swapL)
//                            if (arr[i] < arr[swapL])
//                            {
//                                swapL--;
//                            }
//                        }
//                        else
//                        {
//                            swapL = -2; //more than one swap
//                        }


//                        if (swapL == i - 1)
//                        {
//                            swapL--;
//                        }
//                    }
//                }
//            }

//            //reverse if end not determined
//            if (revStart != -1 && revEnd == -1)
//            {
//                if (arr[arr.Count - 1] < arr[revStart])
//                    revEnd = arr.Count - 1;
//                else
//                {
//                    revEnd = revStart;
//                    revStart--;
//                }
//            }

//            //swap if Right not determined
//            if (swapL != -1 && swapR == -1)
//            {
//                swapR = swapL;
//                swapL = swapL - 1;
//            }

//            if (swapL > -1)
//            {
//                if (
//                    (arr[swapR] <= arr[swapL + 1])
//                    && (arr[swapL] >= arr[swapR - 1])
//                    && (swapL <= 0 || arr[swapR] > arr[swapL - 1])
//                    && ((swapR >= arr.Count - 1) || arr[swapL] < arr[swapR + 1])
//                   )
//                {
//                    Console.WriteLine("yes");
//                    Console.WriteLine("swap " + (swapL + 1) + " " + (swapR + 1));
//                    return;
//                }
//            }

//            if (revStart != -1 && revEnd != 0)
//            {
//                if (
//                    (revStart <= 0 || arr[revEnd] > arr[revStart - 1])
//                    && (revEnd >= arr.Count - 1 || arr[revStart] < arr[revEnd + 1])
//                    )
//                {
//                    Console.WriteLine("yes\nreverse " + (revStart + 1) + " " + (revEnd + 1));
//                    return;
//                }
//            }

//            if (revStart == -1 && revEnd == -1 && swapL == -1 && swapR == -1)
//            {
//                Console.WriteLine("yes");
//                return;

//            }

//            Console.WriteLine("no");
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//            Result.almostSorted(arr);
//        }
//    }

//}
