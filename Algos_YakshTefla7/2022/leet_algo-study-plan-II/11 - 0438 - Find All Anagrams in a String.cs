////https://leetcode.com/problems/find-all-anagrams-in-a-string/

//using System.Collections.Generic;

//public class Solution
//{
//    public IList<int> FindAnagrams(string s, string p)
//    {
//        int[] pArr = new int[26];
//        if(s.Length < p.Length)
//            return new List<int>();

//        //populating signature for string P
//        for(int i = 0; i < p.Length; i++)
//            pArr[p[i] - 'a']++;

//        var result = new List<int>();
        
//        int[] sArr = new int[26];

//        for (int i = s.Length - 1; i > s.Length - 1 - p.Length; i--)
//            sArr[s[i] - 'a']++;

//        bool AllEqual = true;

//        for (int j = 0; j < 26; j++)
//        {
//            if (pArr[j] != sArr[j])
//            {
//                AllEqual = false;
//                break;
//            }
//        }

//        if (AllEqual)
//            result.Add(s.Length - p.Length);


//        for (int i = s.Length - p.Length - 1; i >= 0; i--)
//        {
//            sArr[s[i] - 'a']++;
//            sArr[s[i + p.Length] - 'a']--;

//            AllEqual = true;

//            for (int j = 0; j < 26; j++)
//            {
//                if (pArr[j] != sArr[j])
//                {
//                    AllEqual = false;
//                    break;
//                }
//            }

//            if (AllEqual)
//                result.Add(i);
//        }

//        return result;
//    }
//}