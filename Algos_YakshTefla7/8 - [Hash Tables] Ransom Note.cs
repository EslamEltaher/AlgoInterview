//8 https://www.hackerrank.com/challenges/ctci-ransom-note/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps

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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        for (int i = 0; i < note.Length; i++)
        {
            string word = note[i];
            if (!words.ContainsKey(word))
                words.Add(word, 1);
            else
                words[word]++;
        }

        for(int i = 0; i < magazine.Length; i++)
        {
            string word = magazine[i];
            if(words.ContainsKey(word))
            {
                words[word]--;
            }
        }

        foreach (var word in words)
        {
            if (word.Value > 0)
            {
                Console.Write("No");
                return;
            }
        }
        Console.Write("Yes");
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
