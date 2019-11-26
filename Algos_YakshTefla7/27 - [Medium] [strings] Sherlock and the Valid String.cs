////27 https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem

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

//    // Complete the isValid function below.
//    static string isValid(string s)
//    {
//        bool valid = false;

//        Dictionary<char, int> chars = new Dictionary<char, int>();
        
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (!chars.ContainsKey(s[i]))
//                chars.Add(s[i], 1);
//            else
//                chars[s[i]]++;
//        }

//        int[] times = new int[chars.Count];
//        int ii = 0;

//        foreach (var key in chars.Keys)
//            times[ii++] = chars[key];

//        Array.Sort(times);

//        int num1 = -1;
//        int num2 = -1;

                
//        valid = //all chars are of equal length
//                    (times[0] == times[times.Length - 1])                                                   
//            //all chars are of equal length & only one with one more occurance
//                || (times[0] == times[times.Length - 2] && times[times.Length - 1] == times[0] + 1)         

//            //all chars are of equal length and one char is of one occurance (will be deleted)
//            || (times[0] == 1 && times[1] == times[times.Length - 1]);


//        return valid ? "YES" : "NO";
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s = Console.ReadLine();

//        string result = isValid(s);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
