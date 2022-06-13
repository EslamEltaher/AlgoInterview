////https://leetcode.com/problems/container-with-most-water/

//using System;

//public class Solution
//{
//    public int MaxArea(int[] height)
//    {
//        int max = 0;

//        #region Naive Approach
//        //for (int i = 0; i < height.Length - 1; i++)
//        //{
//        //    for (int j = i; j < height.Length; j++) {
//        //        int area = Math.Min(height[i], height[j]) * (j - i);
//        //        if(area > max) max = area;
//        //    }
//        //}
//        #endregion

//        #region Attempt 2
//        int left = 0;
//        int right = height.Length - 1;

//        while(left < right)
//        {
//            int area = Math.Min(height[left], height[right]) * (right - left);

//            if (area > max)
//                max = area;

//            if (height[left] < height[right])
//                left++;
//            else
//                right--;
//        }
//        #endregion

//        return max;
//    }
//}

//test commit