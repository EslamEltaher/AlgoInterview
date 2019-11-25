//26 https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {
        Dictionary<int, int> ScoreRanks = new Dictionary<int, int>();

        Array.Sort(scores);
        scores = scores.Reverse().ToArray();

        int num = scores[0];
        int j = 1;

        ScoreRanks.Add(scores[0], j++);

        for(int i = 1; i < scores.Length; i++)
        {
            if (scores[i] != num)
                ScoreRanks.Add(scores[i], j++);

            num = scores[i];
        }

        int[] aliceRanks = new int[alice.Length];

        for (int i = 0; i < alice.Length; i++)
            aliceRanks[i] = ScoreRanks[alice[i]];

        return aliceRanks;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
