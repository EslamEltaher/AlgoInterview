////15 https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem

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

//class Result
//{

//    /*
//     * Complete the 'sherlockAndAnagrams' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts STRING s as parameter.
//     */

//    public static int sherlockAndAnagrams(string s)
//    {
//        //Solution after opening editorial

//        var signatures = new Dictionary<string, int>();
//        for(int i = 0; i < s.Length; i++)
//        {
//            var prev = new int[26];
//            for(int j = i; j < s.Length; j++)
//            {
//                var signature = new int[26];
//                prev.CopyTo(signature, 0);

//                signature[s[j] - 'a']++;

//                var sig = string.Join(",",signature);

//                if (!signatures.ContainsKey(sig))
//                    signatures.Add(sig, 0);

//                signatures[sig]++;

//                prev = signature;
//            }
//        }

//        int count = 0;

//        foreach(int value in signatures.Values)
//        {
//            int val = value;
//            while(val > 1)
//            {
//                count += val - 1;
//                val--;
//            }
//        }

//        return count;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int q = Convert.ToInt32(Console.ReadLine().Trim());

//        for (int qItr = 0; qItr < q; qItr++)
//        {
//            string s = Console.ReadLine();

//            int result = Result.sherlockAndAnagrams(s);

//            textWriter.WriteLine(result);
//        }

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
