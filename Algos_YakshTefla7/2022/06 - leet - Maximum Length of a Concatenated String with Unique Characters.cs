////6 https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/

//using System.Collections.Generic;

//public class Solution
//{
//    public int MaxLength(IList<string> arr)
//    {
//        //int max = 0;

//        //for(int i = 0; i < arr.Count; i++)
//        //{
//        //    if(arr[i].Length > max)
//        //        max = arr[i].Length;

//        //    for(int j = i + 1; j < arr[i].Length; j++)
//        //    {
//        //        var str = arr[i] + arr[j];
//        //        int[] chars = new int[26];

//        //        bool repeated=false;
//        //        for (int k=0; k<str.Length; k++)
//        //        {
//        //            chars[str[k] - 'a']++;
//        //        }
//        //        for(int k = 0; k<chars.Length; k++)
//        //        {
//        //            if(chars[k] > 1)
//        //                repeated = true;

//        //        }

//        //        if (!repeated && str.Length > max)
//        //            max = str.Length;

//        //    }
//        //}

//        //return max;

//        int[,] chars = new int[26,arr.Count];

//        for(int i = 0; i < arr.Count; i++)
//        {
//            for(int j = 0; j < arr[i].Length; j++)
//            {
//                chars[arr[i][j], i] = arr[i][j];
//            }
//        }
//    }
//}