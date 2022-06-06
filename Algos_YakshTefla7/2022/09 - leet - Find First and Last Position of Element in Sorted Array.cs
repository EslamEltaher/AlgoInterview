////9 https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
////public class Program { public static void Main(string[] args) {
////        new Solution().SearchRange(new int[]
////{ 5, 7, 7, 8, 8, 10
////}, 8); } }

//public class Solution
//{
//    public int[] SearchRange(int[] nums, int target)
//    {
//        int low = 0;
//        int high = nums.Length - 1;

//        int first = -1;
//        int last = -1;

//        while(low <= high)
//        {
//            int mid = (low + high) / 2;


//            if (nums[mid] == target)
//            {
//                int curr = mid;

//                first = mid;
//                last = mid;

//                int currLow = low;
//                int currHigh = curr;
//                first = GetFirst(nums, target, first, currLow, currHigh);

//                currLow = curr;
//                currHigh = high;
//                last = GetLast(nums, target, last, currLow, currHigh);

//                break;
//            }
//            if (target > nums[mid])
//            {
//                low = mid + 1;
//            }
//            else if(target < nums[mid]) { 
//                high = mid - 1;
//            }
//        }

//        return new int[] { first, last };
//    }

//    private static int GetLast(int[] nums, int target, int last, int currLow, int currHigh)
//    {
//        while (currLow < currHigh)
//        {
//            int mid = (currLow + currHigh) / 2;

//            if (nums[mid] == target)
//            {
//                last = mid;
//                currLow = mid + 1;
//            }
//            else
//                currHigh = mid;
//        }

//        return last;
//    }

//    private static int GetFirst(int[] nums, int target, int first, int currLow, int currHigh)
//    {
//        while (currLow < currHigh)
//        {
//            int mid = (currLow + currHigh) / 2;

//            if (nums[mid] == target)
//            {
//                first = mid;
//                currHigh = mid - 1;
//            }
//            else
//                currLow = mid;
//        }

//        return first;
//    }
//}