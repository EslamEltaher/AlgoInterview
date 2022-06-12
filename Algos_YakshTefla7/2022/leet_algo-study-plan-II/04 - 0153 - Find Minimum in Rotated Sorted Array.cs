////https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/

//public class Solution
//{
//    public int FindMin(int[] nums)
//    {
//        #region Working Accepted Solution
//        //int turningPoint = -1;

//        //int left = 0;
//        //int right = nums.Length - 1;

//        //int midIndex = (left + right) / 2;
//        //int midEl = nums[midIndex];

//        ////searching left
//        //left = 0;
//        //right = midIndex - 1;
//        //while (left <= right)
//        //{
//        //    int mid = (left + right) / 2;

//        //    //found element in the left sequence
//        //    //we go right to find the last element in the left sequence
//        //    if (nums[mid] > midEl)
//        //    {
//        //        turningPoint = mid;

//        //        left = mid + 1;
//        //    }

//        //    //didn't find an element from the left sequence going left
//        //    else
//        //    {
//        //        right = mid - 1;
//        //    }
//        //}


//        ////if turning point not found this means that the left sequence is more than half of the array
//        ////going right to find the beginning of the right sequence

//        //left = midIndex + 1;
//        //right = nums.Length - 1;
//        //if (turningPoint == -1)
//        //{
//        //    while (left <= right)
//        //    {
//        //        int mid = (left + right) / 2;

//        //        //if found we go left to find the first element of the right sequence
//        //        if (nums[mid] < midEl)
//        //        {
//        //            turningPoint = mid - 1;

//        //            right = mid - 1;
//        //        }

//        //        //not found we go further right
//        //        else
//        //        {
//        //            left = mid + 1;
//        //        }
//        //    }
//        //}

//        //return nums[turningPoint + 1];
//        #endregion

//        #region Trying slightly faster solution
//        int turningPoint = -1;

//        //finding the turningPoint at the ending of left sequence
//        //the last element that is higher than Array's element
//        int last = nums[nums.Length - 1];

//        int left = 0;
//        int right = nums.Length - 1;

//        while(left <= right)
//        {
//            int mid = (left + right) / 2;

//            //if we found an element higher than last element (left sequence)
//            //to find the last element in the left sequence we go right
//            if(nums[mid] > last)
//            {
//                turningPoint = mid;

//                left = mid + 1;
//            }

//            else
//            {
//                right = mid - 1;
//            }
//        }

//        return nums[turningPoint + 1];
//        #endregion
//    }
//}