////1 - 3 https://leetcode.com/contest/weekly-contest-296/
////1 - 3 https://leetcode.com/contest/weekly-contest-296/problems/replace-elements-in-an-array/

//using System.Collections.Generic;

//public class Solution
//{
//    public int[] ArrayChange(int[] nums, int[][] operations)
//    {
//        var index = new Dictionary<int, int>();

//        for(int i = 0; i < nums.Length; i++)
//        {
//            index.Add(nums[i], i);
//        }

//        for(int i = 0; i < operations.Length; i++)
//        {
//            nums[index[operations[i][0]]]= operations[i][1];
//            if (!index.ContainsKey(operations[i][1]))
//                index.Add(operations[i][1], index[operations[i][0]]);
//            else index[operations[i][1]] = index[operations[i][0]];
//        }

//        return nums;
//    }
//}