////https://leetcode.com/problems/subarray-product-less-than-k/

//public class Solution
//{
//    public int NumSubarrayProductLessThanK(int[] nums, int k)
//    {
//        int count = 0;

//        #region Naive
//        //for (int i = 0; i < nums.Length; i++)
//        //{
//        //    long prod = 1;
//        //    for (int j = i; j < nums.Length; j++)
//        //    {
//        //        prod *= nums[j];
//        //        if (prod < k)
//        //            count++;
//        //        else
//        //            break;
//        //    }
//        //}
//        #endregion

//        #region Sliding Window (From Solution)
//        //if (k <= 1) return 0;

//        //int left = 0;
//        //int right = 0;

//        //int prod = 1;

//        //while (right < nums.Length)
//        //{
//        //    prod *= nums[right];

//        //    while (prod >= k)
//        //    {
//        //        prod /= nums[left];
//        //        left++;
//        //    }

//        //    //if(prod < k)
//        //    count += right - left + 1;

//        //    right++;
//        //}
//        #endregion

//        return count;
//    }
//}

////public class prog
////{
////    public static void Main(string[] args)
////    {
////        //new Solution().NumSubarrayProductLessThanK(new int[] { 10, 9, 10, 4, 3, 8, 3, 3, 6, 2, 10, 10, 9, 3 }, 19);
////        //var result = new Solution().NumSubarrayProductLessThanK(new int[] { 57, 44, 92, 28, 66, 60, 37, 33, 52, 38, 29, 76, 8, 75, 22 }, 18);
////        var result = new Solution().NumSubarrayProductLessThanK(new int[] { 1,2,3 }, 0);
////    }
////}