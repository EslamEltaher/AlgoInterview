////26 https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem

//using System.CodeDom.Compiler;
////using System.Collections.Generic;
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


//    // Complete the climbingLeaderboard function below.
//    static int[] climbingLeaderboard(int[] scores, int[] alice)
//    {
//        //scores = scores.Distinct().ToArray();

//        int[] aliceRanks = new int[alice.Length];

//        //Edge Case
//        if (scores.Length == 0)
//        {
//            for (int i = 0; i < aliceRanks.Length; i++)
//                aliceRanks[i] = 1;

//            return aliceRanks;
//        }

//        int j = scores.Length - 1;
//        int count = 0;
//        int num = int.MaxValue; //to keep count as zero and trigger when first number that is lower than score is present

//        for (int i = 0; i < alice.Length; i++)
//        {
//            while(j >= 0 && scores[j] <= alice[i])
//            {
//                if(scores[j] != num)
//                    count++;

//                num = scores[j];
//                j--;
//            }

//            aliceRanks[i] = count;
//        }

//        while (j >= 0)
//        {
//            if (scores[j] != num)
//                count++;

//            num = scores[j];
//            j--;
//        }

//        for(int i = 0; i < aliceRanks.Length; i++)
//        {
//            aliceRanks[i] = count - aliceRanks[i] + 1;
//        }

//        return aliceRanks;
//    }

//    #region Solution 1 Not Working (Didn't understand the problem very well)
//    //static int[] climbingLeaderboard(int[] scores, int[] alice)
//    //{
//    //    Dictionary<int, int> ScoreRanks = new Dictionary<int, int>();

//    //    int[] allScores = new int[scores.Length + alice.Length];

//    //    int scoresLength = scores.Length;
//    //    for (int i = 0; i < scoresLength; i++)
//    //    {
//    //        allScores[i] = scores[i];
//    //    }
//    //    for (int i = 0; i < alice.Length; i++)
//    //    {
//    //        allScores[i + scoresLength] = alice[i];
//    //    }

//    //    //for (int i = 0; i < allScores.Length; i++)
//    //    //    Console.WriteLine(allScores[i]);

//    //    Array.Sort(allScores);
//    //    allScores = allScores.Reverse().ToArray();

//    //    for (int i = 0; i < allScores.Length; i++)
//    //        Console.WriteLine(allScores[i]);

//    //    int num = allScores[0];
//    //    int j = 1;

//    //    ScoreRanks.Add(allScores[0], j++);

//    //    for(int i = 1; i < allScores.Length; i++)
//    //    {
//    //        if (allScores[i] != num)
//    //            ScoreRanks.Add(allScores[i], j++);

//    //        num = allScores[i];
//    //    }

//    //    for (int i = 0; i < allScores.Length; i++)
//    //        Console.WriteLine(ScoreRanks[allScores[i]]);

//    //    int[] aliceRanks = new int[alice.Length];

//    //    for (int i = 0; i < alice.Length; i++)
//    //        aliceRanks[i] = ScoreRanks[alice[i]];

//    //    return aliceRanks;
//    //}
//    #endregion

//    #region Solution 2 Linked List (TIMEOUT)
//    //static int[] climbingLeaderboard(int[] scores, int[] alice)
//    //{
//    //    int[] aliceRanks = new int[alice.Length];

//    //    LinkedList scoreRanksList = new LinkedList();

//    //    int[] allScores = new int[scores.Length + alice.Length];

//    //    int scoresLength = scores.Length;
//    //    for (int i = 0; i < scoresLength; i++)
//    //    {
//    //        allScores[i] = scores[i];
//    //    }
//    //    for (int i = 0; i < alice.Length; i++)
//    //    {
//    //        allScores[i + scoresLength] = alice[i];
//    //    }

//    //    Array.Sort(allScores);
//    //    allScores = allScores.Reverse().ToArray();

//    //    int num = allScores[0];
//    //    scoreRanksList.InsertSorted(num);
//    //    for (int i = 1; i < allScores.Length; i++)
//    //    {
//    //        if (allScores[i] != num)
//    //            scoreRanksList.InsertSorted(allScores[i]);

//    //        num = allScores[i];
//    //    }

//    //    for(int i = 0; i < alice.Length; i++)
//    //    {
//    //        aliceRanks[i] = scoreRanksList.IndexOf(alice[i]) + 1;
//    //    }

//    //    return aliceRanks;
//    //}
//    #endregion

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int scoresCount = Convert.ToInt32(Console.ReadLine());

//        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
//        ;
//        int aliceCount = Convert.ToInt32(Console.ReadLine());

//        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
//        ;
//        int[] result = climbingLeaderboard(scores, alice);

//        textWriter.WriteLine(string.Join("\n", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}