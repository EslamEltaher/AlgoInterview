////https://www.hackerrank.com/challenges/angry-children-2/problem

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
//         * Complete the 'angryChildren' function below.
//         *
//         * The function is expected to return a LONG_INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER k
//         *  2. INTEGER_ARRAY packets
//         */

//        public static long angryChildren(int k, List<long> packets)
//        {

//            packets.Sort();
//            long min = 0;
//            int n = packets.Count;

//            if (k == 2)
//            {
//                for (int i = 1; i < packets.Count; i++)
//                {
//                    long c = packets[i] - packets[i - 1];
//                    if (c < min)
//                        min = c;
//                }
//                return min;
//            }


//            ////naive not-correct
//            //for (int i = 0; i < n - (k - 1); i++)
//            //{
//            //    int current = 0;
//            //    int[] adjacentDiffs = new int[k - 1];
//            //    for (int j = i + 1; j <= i + (k - 1); j++)
//            //    {
//            //        int adjacentDiff = packets[j] - packets[j - 1];
//            //        adjacentDiffs[j - (i + 1)] = adjacentDiff;
//            //    }

//            //    for (int i = 0; i +)
//            //        if (current < min)
//            //            min = current;
//            //}

//            //Attempt 2   4 timeout 5 wrong answer
//            //int[] diffs = new int[n];
//            //for (int i = 1; i < n; i++)
//            //{
//            //    diffs[i] = packets[i] - packets[i - 1];
//            //}

//            //int[] sum = new int[n];

//            //for (int i = 0; i < n - (k-1); i++)
//            //{
//            //    int current = 0;

//            //    sum[i] = 0;
//            //    for (int j = i + 1; j <= i + (k - 1); j++)
//            //    {
//            //        sum[j] = (j - i) * diffs[j] + sum[j - 1];
//            //        current += sum[j];
//            //    }

//            //    if (current < min)
//            //        min = current;
//            //}


//            /////////////////////////////////////
//            //// Attempt 3 (knapsack)  WORKS but uses much space (Only trianlge of the square is used)
//            ////                                              ALSO in case n = 10^5    knapsack = 10,000,000,000 (10 billion int = 40TB)



//            ////filling the knapsack
//            ////if(n = 5 and k = 3)  i = 0,1,2,3 j = 1,2,3,4
//            //int[,] knapsack = new int[n, n];
//            //for (int i = 0; i < n - 1; i++)
//            //{
//            //    for(int j = i + 1; j < n; j++)
//            //    {
//            //        knapsack[i, j] = packets[j] - packets[i];
//            //    }
//            //}

//            ///////////
//            /////     n = 50, k = 3
//            /////     10 ,  30,  50 , 80, 90
//            /////     ________________________
//            ///// 10  | 0 | 20 | 40 | 70 | 80 |
//            ///// 30  | 0 |  0 | 20 | 50 | 60 |
//            ///// 50  | 0 |  0 |  0 | 30 | 40 |
//            ///// 80  | 0 |  0 |  0 |  0 | 10 |
//            ///// 90  | 0 |  0 |  0 |  0 |  0 |
//            /////     ______________________
//            /////     
//            ///// 
//            ///// Step 1: SELECTING MINIMUM as first K number (K-1 ROWS (0, K-2) && K COLUMNS (0, K-1))
//            /////     10 ,  30,  50 , 80, 90    (10, 30, 50) S
//            /////     ________________________
//            ///// 10  |*0 |*20 |*40 | 70 | 80 |
//            ///// 30  |*0 |* 0 |*20 | 50 | 60 |
//            ///// 50  | 0 |  0 |  0 | 30 | 40 |
//            ///// 80  | 0 |  0 |  0 |  0 | 10 |
//            ///// 90  | 0 |  0 |  0 |  0 |  0 |
//            /////     _______________________



//            //min = 0;
//            ////k = 3,  i=0,1 ,  j=0,1,2
//            //for(int i = 0; i <= k - 2; i++)
//            //{
//            //    for (int j = 0; j < k; j++)
//            //        min += knapsack[i, j];
//            //}
//            //long current = min;

//            ///// Step 3: [ITERATIVE] Select next K Numbers (30, 50, 80)
//            /////     10 ,  30,  50 , 80, 90    (30, 50, 80)
//            /////     
//            /////  Step 3.1: remove previous row (K numbers (i-1,     from i -1 to i + k - 2)
//            /////             Add next ROW       (K numbers (i+K-2,   from i    to i + K - 1)
//            /////             
//            /////     10 ,  30,  50 , 80, 90 
//            /////     ________________________
//            ///// 10  |-0 |-20 |-40 | 70 | 80 |
//            ///// 30  |*0 |* 0 |*20 | 50 | 60 |
//            ///// 50  | 0 |+ 0 | +0 |+30 | 40 |
//            ///// 80  | 0 |  0 |  0 |  0 | 10 |
//            ///// 90  | 0 |  0 |  0 |  0 |  0 |
//            /////     _______________________
//            /////     
//            /////  Step 3.2 remove previous Column (K-2 items, from i to i + k - 3,  i - 1)
//            /////           ADD Next Column        (K-2 items, from i to i + K - 3,  i + k - 1)
//            /////     
//            /////     10 ,  30,  50 , 80, 90 
//            /////     ________________________
//            ///// 10  |-0 |-20 |-40 | 70 | 80 |
//            ///// 30  |-0 |* 0 |*20 |+50 | 60 |
//            ///// 50  | 0 |+ 0 | +0 |+30 | 40 |
//            ///// 80  | 0 |  0 |  0 |  0 | 10 |
//            ///// 90  | 0 |  0 |  0 |  0 |  0 |
//            /////     _______________________
//            /////     
//            /////     
//            /////     Step 3 is repeated
//            /////     Until last rectangle (50, 80, 90) 
//            /////                i = n - k
//            /////                i=2
//            /////     10 ,  30,  50 , 80, 90 
//            /////     ________________________
//            ///// 10  | 0 | 20 | 40 | 70 | 80 |
//            ///// 30  | 0 |  0 | 20 | 50 | 60 |
//            ///// 50  | 0 |  0 | *0 |*30 |*40 |
//            ///// 80  | 0 |  0 | *0 | *0 |*10 |
//            ///// 90  | 0 |  0 |  0 |  0 |  0 |
//            /////     _______________________



//            ////assume n = 4, k = 3 i = (from 1 to 1)
//            //for (int i = 1; i <= n - k; i++)
//            //{
//            //    //step 3.1
//            //    //i = 1, k = 3, j = (from 1 to 3)
//            //    for (int j = i; j <= i + (k - 1); j++)
//            //    {
//            //        current -= knapsack[i - 1, j - 1];  // [0,  0 - 1 - 2]
//            //        current += knapsack[i + (k - 2), j]; //[2,  1 - 2 - 3]
//            //    }

//            //    //i = 1, k = 3,  j = 1
//            //    for (int j = i; j <= i + k - 3; j++)
//            //    {
//            //        current -= knapsack[j, i - 1];  //[1 ,0]
//            //        current += knapsack[j, i + (k - 1)]; //[1, 3]
//            //    }


//            //    if (current < min)
//            //        min = current;
//            //}


//            ///////////////////////////////////////////////
//            /// Attempt 4.1  Linear 
//            //for (int i = 1; i < k; i++)
//            //{
//            //    for (int j = i; j >= 0; j--)
//            //        min += packets[i] - packets[j];
//            //}

//            //long current = min;
//            ///// Attempt 4.1  WORKS but Time limit exceeded
//            //for(int i = k; i < n; i++)
//            //{
//            //    for(int j = 0; j < k - 1; j++)
//            //    {
//            //        current += packets[i] - packets[i - 1 - j];
//            //        current -= packets[i - 1 - j] - packets[i - k];
//            //    }
//            //    if (current < min)
//            //        min = current;
//            //}
//            /// Attempt 4.2  WORKS but Time limit exceeded
//            /// 

//            long previousK_1 = 0;

//            //optimizing first loop
//            //for (int i = 1; i < k; i++)
//            //{
//            //    previousK_1 += packets[i];
//            //    for (int j = i - 1; j >= 0; j--)
//            //        min += packets[i] - packets[j];
//            //}

//            for (int i = 0; i < k; i++)
//            {
//                //min += (i - (k - 1 - i)) * packets[i];

//                //OR
//                int positive = i;
//                int negative = k - 1 - i;
//                min += (long)(positive - negative) * (long)packets[i];
//                previousK_1 += packets[i];
//            }
//            previousK_1 -= packets[0];

//            long current = min;
//            for (int i = k; i < n; i++)
//            {
//                current += (k - 1) * packets[i];
//                current += (k - 1) * packets[i - k];
//                current -= 2 * previousK_1;

//                previousK_1 -= packets[i - k + 1];
//                previousK_1 += packets[i];

//                if (current < min)
//                    min = current;
//            }
//            return min;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            int k = Convert.ToInt32(Console.ReadLine().Trim());

//            List<long> packets = new List<long>();

//            for (int i = 0; i < n; i++)
//            {
//                long packetsItem = Convert.ToInt64(Console.ReadLine().Trim());
//                packets.Add(packetsItem);
//            }

//            long result = Result.angryChildren(k, packets);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}

//// Dynamic Programming