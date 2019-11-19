////6 https://www.hackerrank.com/challenges/acm-icpc-team

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

//    // Complete the acmTeam function below.
//    static int[] acmTeam(string[] topic)
//    {
//        int numOfAttendees = topic.Length;
//        if (numOfAttendees == 1)
//            return new int[] { topicsForTeam(topic[0], topic[0]), 0 };

//        int maxNumofTopics = 0;
//        int maxNumOfTeams = 0;

//        for (int i = 0; i < numOfAttendees; i++)
//        {
//            for (int j = i; j < numOfAttendees; j++)
//            {
//                if (i != j)
//                {
//                    int commonTopics = topicsForTeam(topic[i], topic[j]);
//                    if (commonTopics == maxNumofTopics)
//                        maxNumOfTeams++;

//                    if(commonTopics > maxNumofTopics)
//                    {
//                        maxNumofTopics = commonTopics;
//                        maxNumOfTeams = 1;
//                    }
//                }
//            }
//        }

//        return new int[] { maxNumofTopics, maxNumOfTeams };
//    }

//    static int topicsForTeam(string member1, string member2)
//    {
//        int commonTopics = 0;
//        for(int i = 0; i < member1.Length; i++)
//        {
//            //if (bitWiseOr(member1[i], member2[i]) == '1')
//            if(member1[i] == '1' || member2[i] == '1')
//                commonTopics++;
//        }
//        return commonTopics;
//    }

//    //static char bitWiseOr(char a, char b)
//    //{
//    //    return a == '1' ? '1' : '0';
//    //}

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nm = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nm[0]);

//        int m = Convert.ToInt32(nm[1]);

//        string[] topic = new string[n];

//        for (int i = 0; i < n; i++)
//        {
//            string topicItem = Console.ReadLine();
//            topic[i] = topicItem;
//        }

//        int[] result = acmTeam(topic);

//        textWriter.WriteLine(string.Join("\n", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
