////https://www.geeksforgeeks.org/binary-indexed-tree-range-updates-point-queries/?fbclid=IwAR10xoZSc868Oncr4ggyN811lUpzgN8ZSViOtLmd-pGxIU_2zZSIVN1QFlw

//using System.Collections.Generic;
//using System;
//using System.Net.Http;

//class Solution
//{
//    //5
//    //3
//    //3
//    //123
//    //123
//    //123

//    //brute force
//    static long maxValue_Method1(int n, int[][] rounds)
//    {
//        int[] investments = new int[n];

//        for (int i = 0; i < rounds.Length; i++)
//        {
//            int start = rounds[i][0] - 1;
//            int end = rounds[i][1] - 1;

//            for (int j = start; j < end; j++)
//            {
//                investments[j] += rounds[i][2];
//            }
//        }

//        int max = investments[0];
//        for (int i = 1; i < investments.Length; i++)
//        {
//            if (investments[i] > max)
//                max = investments[i];
//        }
//        return max;
//    }

//    static long maxValue(int n, int[][] rounds)
//    {
//        int[] investments = new int[n];

//        for (int i = 0; i < rounds.Length; i++)
//        {
//            int start = rounds[i][0] - 1;
//            int end = rounds[i][1] - 1;
//            int contribution = rounds[i][2];

//            investments[start] += contribution;     //add to the begging of range

//            if(end < investments.Length - 1)        //subtract from the element after the end of range
//                investments[end + 1] -= contribution;   
//        }

//        int max = investments[0];
//        int currentInvestment = investments[0];
//        for (int i = 1; i < investments.Length; i++)
//        {
//            currentInvestment += investments[i];
//            if (currentInvestment > max)
//                max = currentInvestment;
//        }
//        return max;
//    }

//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
       

//        int n = Convert.ToInt32(Console.ReadLine());

//        int o = Convert.ToInt32(Console.ReadLine());

//        int[][] rounds = new int[o][];
//        for (int i = 0; i < o; i++)
//            rounds[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

//        var result = maxValue(n, rounds);

//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
