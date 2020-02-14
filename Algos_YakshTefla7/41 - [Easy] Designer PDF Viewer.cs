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

//    // Complete the designerPdfViewer function below.
//    static int designerPdfViewer(int[] h, string word)
//    {
//        int charWidth = 1;

//        int[] chars = new int[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

//        int maxHeight = 1;
//        for (int i = 0; i < word.Length; i++)
//        {
//            var index = Array.IndexOf(chars, word[i]);
//            var charLength = h[index];

//            if (charLength > maxHeight)
//                maxHeight = charLength;
//        }

//        return maxHeight * charWidth * word.Length;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
//        ;
//        string word = Console.ReadLine();

//        int result = designerPdfViewer(h, word);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
