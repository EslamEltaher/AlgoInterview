////29 https://www.hackerrank.com/challenges/greedy-florist/problem

//using System.IO;
//using System;

//class Solution
//{

//    // Complete the getMinimumCost function below.
//    static int getMinimumCost(int k, int[] c)
//    {
//        int cost = 0;
//        int multiplier = 1;

//        Array.Sort(c);

//        for (int i = c.Length - 1; i >= 0; i--)
//        {
//            cost += multiplier * c[i];

//            if ((c.Length - i)% k == 0)
//                multiplier++;
//        }
//        return cost;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nk = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nk[0]);

//        int k = Convert.ToInt32(nk[1]);

//        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
//        int minimumCost = getMinimumCost(k, c);

//        //Console.WriteLine(minimumCost);
//        //Console.ReadLine();

//        textWriter.WriteLine(minimumCost);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
