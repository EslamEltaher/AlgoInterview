////11 https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings

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

//    // Complete the makeAnagram function below.
//    static int makeAnagram(string a, string b)
//    {
//        if (a.Length == 0)
//            return b.Length;

//        if (b.Length == 0)
//            return a.Length;

//        Dictionary<char, int> charsA = new Dictionary<char, int>();
//        Dictionary<char, int> charsB = new Dictionary<char, int>();

//        for (int i = 0; i < a.Length; i++)
//        {
//            if (!charsA.ContainsKey(a[i]))
//                charsA.Add(a[i], 1);
//            else
//                charsA[a[i]]++;
//        }

//        for (int i = 0; i < b.Length; i++)
//        {
//            if (!charsB.ContainsKey(b[i]))
//                charsB.Add(b[i], 1);
//            else
//                charsB[b[i]]++;
//        }

//        int deletions = 0;


//        int charsACount = charsA.Count;
//        int charsBCount = charsB.Count;

//        foreach(char k in charsA.Keys)
//        {
//            if (!charsB.ContainsKey(k))
//                deletions += charsA[k];
//            else
//            {
//                int aTimes = charsA[k];
//                int bTimes = charsB[k];

//                if (aTimes > bTimes)
//                    deletions += aTimes - bTimes;
//                else
//                    deletions += bTimes - aTimes;
//            }
//        }

//        foreach (char k in charsB.Keys)
//        {
//            if (!charsA.ContainsKey(k))
//                deletions += charsB[k];
//        }

//        return deletions;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string a = Console.ReadLine();

//        string b = Console.ReadLine();

//        int res = makeAnagram(a, b);

//        textWriter.WriteLine(res);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
