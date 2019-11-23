////9 https://www.hackerrank.com/challenges/two-strings/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps&h_r=next-challenge&h_v=zen

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

//class Solution {

//    // Complete the twoStrings function below.
//    static string twoStrings(string s1, string s2) {
//        var chars = new HashSet<char>();


//        string stringToCheckAgainst = s1.Length < s2.Length ? s1 : s2;
//        string stringToCheck = s1.Length < s2.Length ? s2 : s1;

//        for (int i = 0; i < stringToCheckAgainst.Length; i++)
//        {
//            if (!chars.Contains(stringToCheckAgainst[i]))
//                chars.Add(stringToCheckAgainst[i]);
//        }

//        for (int i = 0; i < stringToCheck.Length; i++)
//        {
//            if (chars.Contains(stringToCheck[i]))
//                return "YES";
//        }

//        return "NO";
//    }

//    static void Main(string[] args) {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int q = Convert.ToInt32(Console.ReadLine());

//        for (int qItr = 0; qItr < q; qItr++) {
//            string s1 = Console.ReadLine();

//            string s2 = Console.ReadLine();

//            string result = twoStrings(s1, s2);

//            textWriter.WriteLine(result);
//        }

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
