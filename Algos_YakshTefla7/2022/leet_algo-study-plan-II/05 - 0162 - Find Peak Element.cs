////https://leetcode.com/problems/find-peak-element/

//public class Solution
//{
//    public int FindPeakElement(int[] nums)
//    {
//        if (nums.Length == 1 || nums[0] > nums[1])
//            return 0;

//        if (nums[nums.Length - 1] > nums[nums.Length - 2])
//            return nums.Length - 1;


//        #region My Linear O(N) Solution
//        //for (int i = 1; i < nums.Length - 1; i++)
//        //{
//        //    if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
//        //        return i;
//        //}

//        //return -1;
//        #endregion

//        #region Binary Solution from Leetcode O(LogN)
//        int left = 1;
//        int right = nums.Length - 2;

//        while(left <= right)
//        {
//            int mid = (left + right) / 2;

//            if (nums[mid] > nums[mid + 1] && nums[mid] > nums[mid - 1])
//                return mid;

//            else if (nums[mid] > nums[mid + 1])
//                right = mid - 1;
//            else
//                left = mid + 1;
//        }

//        return -1;
//        #endregion
//    }
//}