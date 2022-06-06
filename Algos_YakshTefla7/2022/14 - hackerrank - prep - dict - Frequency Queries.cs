////14 https://www.hackerrank.com/challenges/frequency-queries/problem

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

//    // Complete the freqQuery function below.
//    static List<int> freqQuery(List<List<int>> queries)
//    {
//        var result = new List<int>();

//        var hashTable = new Dictionary<int, int>();
//        var freq = new Dictionary<int, int>();

//        foreach (var query in queries)
//        {
//            if(!hashTable.ContainsKey(query[1]))
//            {
//                hashTable.Add(query[1], 0);
//            }

//            var next = 0;
//            var prev = 0;

//            if (query[0] == 1) {
//                prev = hashTable[query[1]];
//                next = prev + 1;

//                hashTable[query[1]] = next;
//            } else if (query[0] == 2) {
//                prev = hashTable[query[1]];
//                next = Math.Max(prev - 1, 0);

//                hashTable[query[1]] = next;
//            } else if (query[0] == 3) {
//                result.Add(freq.ContainsKey(query[1]) && freq[query[1]] > 0 ? 1 : 0);
//            }

//            if(query[0] != 3)
//            {
//                if(prev != 0)
//                {
//                    freq[prev]--;
//                }

                
//                if (!freq.ContainsKey(next))
//                    freq.Add(next, 0);

//                if (next != 0)
//                {
//                    freq[next]++;
//                }
//            }
//        }

//        return result;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int q = Convert.ToInt32(Console.ReadLine().Trim());

//        List<List<int>> queries = new List<List<int>>();

//        for (int i = 0; i < q; i++)
//        {
//            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
//        }

//        List<int> ans = freqQuery(queries);

//        textWriter.WriteLine(String.Join("\n", ans));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
