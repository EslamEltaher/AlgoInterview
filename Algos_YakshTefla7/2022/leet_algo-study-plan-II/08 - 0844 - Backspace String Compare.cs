////https://leetcode.com/problems/backspace-string-compare/

//public class Solution
//{
//    public bool BackspaceCompare(string s, string t)
//    {
//        int backspaces = 0;

//        var sArr = s.ToCharArray();
//        var tArr = t.ToCharArray();

//        for (int i = sArr.Length - 1; i >= 0; i--)
//        {
//            if(sArr[i] == '#')
//                backspaces++;
//            else if(backspaces > 0)
//            {
//                sArr[i] = '#';
//                backspaces--;
//            }
//        }

//        backspaces = 0;

//        for (int i = tArr.Length - 1; i >= 0; i--)
//        {
//            if(tArr[i] == '#')
//            {
//                backspaces++;
//            }
//            else if(backspaces > 0)
//            {
//                tArr[i] = '#';
//                backspaces--;
//            }

//        }

//        int sIndex = 0;
//        int tIndex = 0;

//        while (tIndex < tArr.Length && sIndex < sArr.Length)
//        {
//            while(tIndex < tArr.Length && tArr[tIndex] == '#')
//                tIndex++;

//            while(sIndex < sArr.Length && sArr[sIndex] == '#')
//                sIndex++;

//            if (sIndex >= sArr.Length || tIndex >= tArr.Length)
//                break;

//            if (sArr[sIndex] != tArr[tIndex])
//                return false;

//            tIndex++;
//            sIndex++;
//        }

//        while (tIndex < tArr.Length && tArr[tIndex] == '#')
//            tIndex++;

//        while (sIndex < sArr.Length && sArr[sIndex] == '#')
//            sIndex++;

//        if (sIndex >= sArr.Length && tIndex >= tArr.Length)
//            return true;

//        if (sIndex >= sArr.Length || tIndex >= tArr.Length)
//            return false;

//        return true;
//    }
//}