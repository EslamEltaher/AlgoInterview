////https://leetcode.com/problems/search-in-rotated-sorted-array/

//public class Solution
//{
//    public int Search(int[] nums, int target)
//    {
//        if (nums.Length == 1)
//            return nums[0] == target ? 0 : -1;

//        int turningPoint = -1;

//        int left = 0;
//        int right = nums.Length - 1;

//        #region Find Sequence Wrong way
//        ////finding the turining point where elements start the new sequence
//        ////searching to the left
//        //while (left <= right)
//        //{
//        //    int mid = (left + right) / 2;

//        //    if (nums[mid] >= nums[mid + 1])
//        //    {
//        //        turningPoint = mid;
//        //        break;
//        //    }

//        //    else
//        //    {
//        //        right = mid - 1;
//        //    }
//        //}

//        ////if turning point was not found in the left area
//        ////searching to the right
//        //if (turningPoint == -1)
//        //{
//        //    left = 0;
//        //    right = nums.Length - 1;

//        //    while(left <= right)
//        //    {
//        //        int mid = (left + right) / 2;

//        //        if (mid < nums.Length - 1 && nums[mid] > nums[mid + 1])
//        //            turningPoint = mid;

//        //        else
//        //        {
//        //            left = mid + 1;
//        //        }
//        //    }
//        //}
//        #endregion

//        #region Find Sequence Right Way
//        int midArrIndex = (left + right) / 2;
//        int midEl = nums[midArrIndex];

//        if (midEl > nums[midArrIndex + 1])
//            turningPoint = midArrIndex;

//        //if turning point is not exactly in the middle we start looking for it
//        if(turningPoint == -1)
//        {
//            //looking for element bigger than middle element in the left side
//            left = 0;
//            right = midArrIndex - 1;

//            //finding the left sequence in the left area
//            while (left <= right)
//            {
//                int mid = (left + right) / 2;

//                //if higher element spotted 
//                //go right to find the last element of the left sequence
//                if (nums[mid] > midEl)
//                {
//                    turningPoint = mid;

//                    left = mid + 1;
//                }

//                //else go the left to find an element in the right sequence
//                else
//                {
//                    right = mid - 1;
//                }
//            }
//        }
        

//        //if left sequence not found in the left area
//        //this means that the left sequence might be more than half of the array
//        //instead we look for right sequence
//        if(turningPoint == -1)
//        {
//            left = midArrIndex + 1;
//            right = nums.Length - 1;

//            while(left <= right)
//            {
//                int mid = (left + right) / 2;

//                //if element is spotted from the right sequence
//                //we go left to find the first element in the right sequence
//                if(nums[mid] < midEl)
//                {
//                    turningPoint = mid - 1;

//                    right = mid - 1;
//                }

//                //we didn't find the element of the left sequence
//                //we continue to right
//                else
//                {
//                    left = mid + 1;
//                }
//            }
//        }
//        #endregion

//        left = 0;
//        right = nums.Length - 1;

//        //if turning point is found we limit search to the left sequence
//        if(turningPoint != -1)
//        {
//            right = turningPoint;
//        }

//        while(left <= right)
//        {
//            int mid = (left + right) / 2;

//            if (nums[mid] == target)
//                return mid;

//            if (nums[mid] < target)
//                left = mid + 1;
//            else if (nums[mid] > target)
//                right = mid - 1;
//        }

//        if (turningPoint == -1)
//            return -1;

//        //we try to find in the right sequence
//        left = turningPoint + 1;
//        right = nums.Length - 1;

//        while (left <= right)
//        {
//            int mid = (left + right) / 2;

//            if (nums[mid] == target)
//                return mid;

//            if (nums[mid] < target)
//                left = mid + 1;
//            else if (nums[mid] > target)
//                right = mid - 1;
//        }

//        return -1;
//    }
//}