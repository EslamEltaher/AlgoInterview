////1 https://leetcode.com/problems/two-sum/

//using System.Collections.Generic;

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        Dictionary<int, int> numIndex = new Dictionary<int, int>();

//        for (int i = 0; i < nums.Length; i++)
//        {
//            if(numIndex.ContainsKey(target - nums[i]))
//                return new int[] { i, numIndex[target - nums[i]] };

//            else if(!numIndex.ContainsKey(nums[i]))
//                numIndex.Add(nums[i], i);
//        }

//        return new int[] { -1, -1 };
//    }
//}