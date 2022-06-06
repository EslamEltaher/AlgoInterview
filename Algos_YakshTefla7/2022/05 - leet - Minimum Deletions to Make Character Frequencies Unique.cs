////5 https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/

//using System;

//public class Solution
//{
//    public int MinDeletions(string s)
//    {
//        int[] letCount = new int[26];

//        for (int i = 0; i < s.Length; i++)
//        {
//            letCount[s[i] - 'a']++;
//        }


//        Array.Sort(letCount);

//        int count = 0;

//        //0 1 2 3 4 6
//       for(int i = letCount.Length - 1; i >= 1 && letCount[i] > 0; i--)
//        {
//            for(int j = i - 1; j >= 0; j--)
//                if(letCount[i] == letCount[j])
//                {
//                    count++;
//                    letCount[j]--;
//                }
//        }
//       return count;
//    }
//}