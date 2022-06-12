////https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

//public class Solution
//{
//    public int[] SearchRange(int[] nums, int target)
//    {
//        int first = -1;
//        int last = -1;

//        int min = 0;
//        int max = nums.Length - 1;

//        while(min <= max)
//        {
//            int mid = (min + max) / 2;

//            if(nums[mid] < target)
//            {
//                min = mid + 1;
//            }
//            else
//            {
//                if (nums[mid] == target)
//                    first = mid;

//                max = mid - 1;
//            }
//        }

//        if (first == -1)
//            return new int[] { -1, -1};

//        min = first;
//        max = nums.Length - 1;

//        while(min <= max)
//        {
//            int mid = (min + max) / 2;

//            if(nums[mid] > target)
//            {
//                max = mid - 1;
//            }
//            else
//            {
//                if (nums[mid] == target)
//                    last = mid;

//                min = mid + 1;
//            }
//        }

//        return new int[] { first, last };
//    }
//}