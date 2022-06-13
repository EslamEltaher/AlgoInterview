////https://leetcode.com/problems/3sum/


//// many edge cases

//// Many Zeros or AllZeros is an edge case to get the array { 0,0,0 }

//// edge case only one positive or one negative ex. { -1, 0, 1 }
////      when fixed left, r1&r2 are the same. or vice versa
////      if fixed inside two loops will result in duplicates
////      Solution: Thrid While Loop for zeros

////edge case when removing duplicates in the two pointers side
////  one of the pointers can exceed array limit 
////  ex. in first loop (Left, r1,r2) two pointers are r1, r2
////      in second loop (right, l1, l2) two pointers are l1, l2
////      removing duplicates like while (nums[r1] == nums[r1 + 1])    r1++;
////      leads to outofIndex
////      Solution: while (r1 < nums.Length - 2 && nums[r1] == nums[r1 + 1])    r1++;


////edge case when using duplicates before removing them (Search for //use duplicates before removing)
////                left   r1          r2
////                   v   v           v
////ex. in this array [-2, 1,1,1,1,1,1,1 ],  left = -2,  r1 = 1, r2 = 1 at any index in the right 
////  if we apply the use of duplicates then it will be used for both r1 & r2 we need to use it once
////      Solution: we add condition (nums[r1] != nums[r2])   same goes for l1,l2

///*
// * 
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⠤⠤⠔⢒⡖⢒⣦⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⢀⡴⠖⠛⠉⠁⠐⠒⠒⡾⣷⠾⠯⠈⠑⢤⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⣰⠋⠀⠀⠀⠀⠀⠀⠀⣟⣿⡇⠀⠀⠀⠀⠀⢳⡀⠀⠀⠀⠀⠀
//⠀⠀⣠⠄⣶⣾⣁⡀⠀⠀⠀⠀⠀⠀⣰⣿⣾⠃⢀⡿⠛⠓⣄⠀⢿⣆⠀⠀⠀⠀
//⠀⢀⢀⡴⠋⠀⠈⠙⢿⡷⠂⠀⠀⠀⡿⡿⠁⡔⠁⠀⠀⡆⠈⢣⡈⢾⡆⠀⠀⠀
//⠀⢸⠎⠀⠀⢀⡠⠤⠤⠽⣄⠀⠀⠀⠹⠇⠸⠀⠀⠀⠀⠉⠐⠊⠹⡌⢳⡀⠀⠀
//⠀⣿⠀⠀⢰⣋⡀⠀⠀⠀⠘⣗⡆⠀⠀⠀⠘⣄⠀⠀⠀⠀⠀⠀⠀⢱⠈⣷⡄⠀
//⡇⡏⠀⠀⣇⣠⠟⠀⠀⠀⠀⢀⠇⠀⢀⣀⣀⣈⠢⣄⡀⠀⠀⠀⣠⠎⠀⢸⡱⡀
//⣿⠀⠀⠀⢸⠀⠀⠀⠀⠀⣠⠋⡠⠚⣅⠀⢸⢄⡩⠓⢭⣉⢉⣉⠁⠀⠀⠀⢃⡇
//⣿⠀⠀⠀⠈⠢⣀⣀⣠⠞⠁⡰⣧⡀⢸⡗⠂⠀⠀⠀⠀⠈⠉⠚⠳⡄⠀⠀⠸⡇
//⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣇⡼⠋⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⡄⠀⠀⡇
//⡟⡀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠁⠀⠀⠀⠀⣀⣀⣠⠞⠉⠣⡀⢀⣀⡀⢸⠀⠀⡇
//⢣⢇⠀⠀⠀⠀⠀⠀⠀⠀⡸⠀⠀⠀⠀⡼⠁⠀⠁⣀⠀⡔⠙⡞⠀⠙⣸⠀⠀⡇
//⠸⡘⡄⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⠘⠁⠀⢀⡎⠉⢓⣡⠔⠓⠒⠚⠁⠀⠀⢹
//⠀⠱⣇⠀⠀⠀⠀⠀⠀⡜⠀⠀⠀⠀⡔⠉⠙⢼⣀⠴⠋⠀⠀⠀⠀⠀⠀⠀⢀⡞
//⠀⠀⢹⢦⠀⠀⠀⠀⢸⣁⠜⠉⠑⠼⢀⣠⠤⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⡼⠁
//⠀⠀⠸⡄⠓⢤⡀⠀⠀⠈⠉⠉⠑⠒⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠃⠀
//⠀⠀⠀⠙⠀⠀⠈⠙⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠃⠀⠀

// * 
// */

//using System;
//using System.Collections.Generic;

//public class Solution
//{
//    public IList<IList<int>> ThreeSum(int[] nums)
//    {
//        var result = new List<IList<int>>();

//        if (nums.Length < 3)
//            return result;

//        Array.Sort(nums);

//        int negativeEnd = -1;
//        int zeroIndex = -1;
//        int positiveStart = -1;

//        int firstZero = -1;

//        for(int i = 0; i < nums.Length; i++)
//        {
//            if (nums[i] < 0)
//                negativeEnd = i;

//            if (nums[i] == 0 && firstZero == -1)
//                firstZero = i;
//            if (nums[i] == 0)
//                zeroIndex = i;

//            if (nums[i] > 0 && positiveStart == -1)
//                positiveStart = i;
//        }

//        //edge case (all zeros)
//        //////////////int leftZero = 0;
//        //////////////int rightZero = nums.Length - 1;

//        //////////////if (positiveStart != -1)    leftZero = positiveStart - 1;
//        //////////////if (negativeEnd != -1)      rightZero = negativeEnd + 1; 
//        if (zeroIndex - firstZero >= 2)
//            result.Add(new List<int>() { 0, 0, 0 });

//        if (positiveStart == -1 || negativeEnd == -1)
//            return result;

//        int left = 0;
//        int right = nums.Length - 1;

//        //left bound
//        while (-nums[left] > 2 * nums[right])
//            left++;

//        //right bound
//        while (nums[right] > -2 * nums[left])
//            right--;


//        #region Attempt 2
//        while(left <= negativeEnd)
//        {
//            //removing duplicates in the one pointer
//            while(nums[left] == nums[left + 1]) left++;


//            int r1 = positiveStart;
//            int r2 = nums.Length - 1;

//            while (r1 < r2)
//            {
//                if(nums[r1] != nums[r2])
//                {
//                    //use duplicates before removing
//                    if (nums[r1] == nums[r1 + 1] && nums[r1] * 2 == -nums[left])
//                        result.Add(new List<int>() { nums[r1], nums[r1], nums[left] });
//                    if (nums[r2] == nums[r2 - 1] && nums[r2] * 2 == -nums[left])
//                        result.Add(new List<int>() { nums[r2], nums[r2], nums[left] });
//                }
                

//                //removing duplicates
//                while (r1 < nums.Length -  1 && nums[r1] == nums[r1 + 1])    r1++;
//                while (nums[r2] == nums[r2 - 1])    r2--;

//                ////////////////////////////////zero case
//                //////////////////////////////if (nums[r1] == -nums[left] || nums[r2] == -nums[left])
//                //////////////////////////////{
//                //////////////////////////////    if (zeroIndex != -1)
//                //////////////////////////////        result.Add(new List<int>() { nums[left], -nums[left], 0 });
//                //////////////////////////////}

//                //normal case
//                if (nums[left] + nums[r1] + nums[r2] == 0)
//                    result.Add(new List<int>() { nums[left], nums[r1], nums[r2] });

//                //if(half range add only once and break all)
//                if (nums[r1] == nums[r2])
//                    break;

//                //decide if sum > 0 to go left 
//                //else if sum < 0 go right
//                //or default case go right
//                if (nums[r1] + nums[r2] + nums[left] > 0) r2--;
//                else r1++;
//            }
//            left++;
//        }

//        while(right >= positiveStart)
//        {
//            //removing duplicates
//            while (nums[right] == nums[right - 1]) right--;

//            int l1 = 0;
//            int l2 = negativeEnd;

//            while (l1 < l2)
//            {
//                if (nums[l1] != nums[l2])
//                {
//                    if (nums[l1] == nums[l1 + 1] && nums[l1] * 2 == -nums[right])
//                        result.Add(new List<int>() { nums[l1], nums[l1], nums[right] });
//                    if (nums[l2] == nums[l2 - 1] && nums[l2] * 2 == -nums[right])
//                        result.Add(new List<int>() { nums[l2], nums[l2], nums[right] });

//                }
//                    //use duplicates before removing

//                //removing duplicates
//                while (nums[l1] == nums[l1 + 1]) l1++;
//                while (l2 > 0 && nums[l2] == nums[l2 - 1]) l2--;

//                //normal case
//                if (nums[right] + nums[l1] + nums[l2] == 0)
//                    result.Add(new List<int>() { nums[right], nums[l1], nums[l2] });

//                //if(half range add only once and break all)
//                if (nums[l1] == nums[l2])
//                    break;

//                //decide if sum > 0 to go left 
//                //else if sum < 0 go right
//                //or default case go right
//                if (nums[l1] + nums[l2] + nums[right] > 0) l2--;
//                else l1++;
//            }

//            right--;
//        }

//        left = 0;
//        right = nums.Length - 1;

//        //no need to check for case numbers equal and including zero ex. { -2, 0, 2 }
//        if (zeroIndex == -1)
//            return result;

//        while (left <= negativeEnd && right >= positiveStart)
//        {
//            //duplicates
//            while (left + 1 <= negativeEnd && nums[left] == nums[left + 1]) left++;
//            while (right - 1 >= positiveStart && nums[right] == nums[right - 1]) right--;

//            if (nums[left] == -nums[right])
//                result.Add(new List<int>() { nums[left], nums[right], 0 });

//            if (-nums[left] > nums[right])
//                left++;
//            else right--;
//        }

//        return result;
//        #endregion

//        #region Failed Attempt
//        //while (left <= negativeEnd && right >= positiveStart)
//        //{
//        //    while (right >= positiveStart + 1)
//        //    {
//        //        if (nums[left] + nums[right] == 0 && zeroIndex != -1)
//        //            result.Add(new List<int>() { nums[left], nums[right], 0 });

//        //        int r2 = right - 1;

//        //        while (r2 >= positiveStart && nums[right] + nums[left] + nums[r2] > 0)
//        //        {
//        //            r2--;
//        //        }

//        //        if (nums[right] + nums[left] + nums[r2] == 0)
//        //            result.Add(new List<int>() { nums[left], nums[right], nums[r2] });

//        //        int currR = nums[right];

//        //        while (nums[right - 1] == currR)
//        //            right--;
//        //        right--;
//        //    }

//        //    if (nums[left] + nums[right] == 0 && zeroIndex != -1)
//        //        result.Add(new List<int>() { nums[left], nums[right], 0 });

//        //    left++;
//        //}

//        //left = lBound;
//        //right = rBound;

//        //while (left <= negativeEnd && right >= positiveStart)
//        //{
//        //    while (left <= negativeEnd - 1)
//        //    {
//        //        int l2 = left + 1;

//        //        if (nums[left] + nums[right] == 0 && zeroIndex != -1)
//        //            result.Add(new List<int>() { nums[left], nums[right], 0 });

//        //        while (l2 >= negativeEnd && nums[right] + nums[left] + nums[l2] < 0)
//        //        {
//        //            l2++;
//        //        }

//        //        if (nums[right] + nums[left] + nums[l2] == 0)
//        //            result.Add(new List<int>() { nums[left], nums[right], nums[l2] });

//        //        int currL = nums[left];
//        //        while (nums[left + 1] == currL)
//        //            left++;

//        //        left++;
//        //    }

//        //    if (nums[left] + nums[right] == 0 && zeroIndex != -1)
//        //        result.Add(new List<int>() { nums[left], nums[right], 0 });


//        //    right--;
//        //}
//        #endregion

//    }
//}

////namespace prog
////{
////    public class Program
////    {
////        public static void Main(string[] args)
////        {
////            //var Solution = new Solution().ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
////            //var Solution = new Solution().ThreeSum(new int[] { -1, 0, 1 });
////            //var Solution = new Solution().ThreeSum(new int[] { 1, 1, -2 });
////            //var Solution = new Solution().ThreeSum(new int[] { 0, 1, 1 });
////            var Solution = new Solution().ThreeSum(new int[] { 3, 0, -2, -1, 1, 2 });
////        }
////    }

////}