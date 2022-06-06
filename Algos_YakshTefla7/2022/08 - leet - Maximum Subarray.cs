////8 https://leetcode.com/problems/maximum-subarray/

//public class Solution
//{
//    public int MaxSubArray(int[] nums)
//    {
//        int curr = 0;
//        int max = int.MinValue;

//        for(int i = 0; i < nums.Length; i++)
//        {
//            if (curr < 0)
//                curr = 0;

//            if(curr + nums[i] < 0)
//                curr = 0;

//            curr += nums[i];

//            if(curr > max)
//                max = curr;
//        }

//        return max;
//    }
//}