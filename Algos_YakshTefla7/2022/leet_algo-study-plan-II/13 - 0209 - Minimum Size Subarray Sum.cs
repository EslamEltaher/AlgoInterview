////https://leetcode.com/problems/minimum-size-subarray-sum/

//public class Solution
//{
//    public int MinSubArrayLen(int target, int[] nums)
//    {
//        int length = 0;

//        int sum = 0;

//        int left = 0;
//        int right = 0;


//        while(right < nums.Length)
//        {
//            sum += nums[right];

//            while(sum >= target)
//            {
//                int windowLength = right - left + 1;

//                if (windowLength > 0 && (length == 0 || windowLength < length))
//                    length = windowLength;

//                sum -= nums[left];
//                left++;
//            }

//            right++;
//        }

//        return length;
//    }
//}