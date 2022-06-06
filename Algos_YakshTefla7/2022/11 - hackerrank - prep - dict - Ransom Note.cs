////11 https://www.hackerrank.com/challenges/ctci-ransom-note/problem

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
//     * Complete the 'checkMagazine' function below.
//     *
//     * The function accepts following parameters:
//     *  1. STRING_ARRAY magazine
//     *  2. STRING_ARRAY note
//     */

//    public static void checkMagazine(List<string> magazine, List<string> note)
//    {
//        if (magazine.Count < note.Count)
//        {
//            Console.WriteLine("No");
//            return;
//        }

//        var dict = new Dictionary<string, int>();

//        for (int i = 0; i < magazine.Count; i++)
//        {
//            if (!dict.ContainsKey(magazine[i]))
//            {
//                dict.Add(magazine[i], 0);
//            }

//            dict[magazine[i]]++;
//        }

//        for (int i = 0; i < note.Count; i++)
//        {
//            if (!dict.ContainsKey(note[i]) || dict[note[i]] == 0)
//            {
//                Console.WriteLine("No");
//                return;
//            }

//            dict[note[i]]--;
//        }

//        Console.WriteLine("Yes");
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//        int m = Convert.ToInt32(firstMultipleInput[0]);

//        int n = Convert.ToInt32(firstMultipleInput[1]);

//        List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

//        List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

//        Result.checkMagazine(magazine, note);
//    }
//}
