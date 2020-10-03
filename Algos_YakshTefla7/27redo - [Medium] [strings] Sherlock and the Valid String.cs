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
//        bool isValid = true;

//        var dict = new Dictionary<char, int>();

//        for(int i = 0; i < s.Length; i++)
//        {
//            if (dict.ContainsKey(s[i]))
//                dict[s[i]]++;
//            else
//                dict[s[i]] = 1;
//        }

//        int repitions = 0;
//        //int consumedLetter = 1;
//        bool consumedLetter = false;
//        bool firstTime = true;  /// EdgeCase if(5,4,4,4,4) OK
//        bool secondTime = true; /// IF (5,5,5,4) NO

//        foreach (char key in dict.Keys)
//        {
//            int current = dict[key];

//            //first time
//            if (firstTime)
//            {
//                repitions = current;
//                firstTime = false;
//            }
//            else
//            {
//                secondTime = false;
//            }

//            int diff = current - repitions;

//            bool currentLessByOne = diff == -1;  //current is less by one ((Edge case as above, it can be switched to current)

//            //instead of Math.Abs
//            diff = Math.Abs(diff);

//            if (diff > 1 || (diff == 1 && consumedLetter == true))
//            {
//                isValid = false;
//                break;
//            }
//            else if (diff == 1)
//            {
//                consumedLetter = true;
//                if(currentLessByOne && secondTime)
//                    repitions = current;
//            }
//        }

//        return isValid ? "YES" : "NO";
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s = Console.ReadLine();

//        string result = isValid(s.ToLower());

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
