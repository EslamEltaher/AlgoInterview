////1 - 2 https://leetcode.com/contest/weekly-contest-296/
////1 - 2 https://leetcode.com/contest/weekly-contest-296/problems/partition-array-such-that-maximum-difference-is-k/
//using System;

//public class Solution
//{
//    public int PartitionArray(int[] nums, int k)
//    {
//        Array.Sort(nums);

//        int curr = nums[0];
//        int count = 1;

//        for(int i = 1; i < nums.Length; i++)
//        {
//            if(nums[i] - curr > k)
//            {
//                count++;
//                curr = nums[i];
//            }
//        }

//        //int count = 0;

//        //int min = nums[0];
//        //int max = nums[0];

//        //for (int i = 1; i < nums.Length; i++)
//        //{
//        //    if ((nums[i] > max && nums[i] - min > k) || (nums[i] < min && max - nums[i] > k))
//        //    {
//        //        count++;
//        //        min = nums[i];
//        //        max = nums[i];
//        //    }

//        //    if (nums[i] < min) min = nums[i];
//        //    if (nums[i] > max) max = nums[i];
//        //}

//        return count;
//    }
//}