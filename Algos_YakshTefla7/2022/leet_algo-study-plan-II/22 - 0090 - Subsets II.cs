////https://leetcode.com/problems/subsets-ii/

//using System;
//using System.Collections.Generic;

//public class Solution
//{
//    public IList<IList<int>> SubsetsWithDup(int[] nums)
//    {
//        Array.Sort(nums);
//        return SubsetsII(nums, 0, nums.Length - 1);
//    }

//    public IList<IList<int>> SubsetsII(int[] nums, int left, int right)
//    {
//        if(left > right)
//            return new List<IList<int>>() { new List<int>() };

//        if(left == right)
//        {
//            return new List<IList<int>>() { new List<int>(), new List<int>() { nums[left] } };
//        }

//        var result = new List<IList<int>>();

//        //get the count of repeated Items
//        int l = left;
//        while (l < nums.Length - 1 && nums[l] == nums[l + 1])
//        {
//            l++;
//        }
//        int countL = l - left + 1;

//        //make left combination from repeated elements
//        List<IList<int>> combL = new List<IList<int>>() { new List<int>() };

//        for(int i = 0; i < countL; i++)
//        {
//            var leftI = new List<int>();

//            for(int j = 0; j < i + 1; j++)
//            {
//                leftI.Add(nums[left]);
//            }

//            combL.Add(leftI);
//        }

//        left = l;

//        var combR = SubsetsII(nums, left + 1, right);

//        var comb = combine(combL, combR);

//        result.AddRange(comb);

//        return result;
//    }

//    public IList<IList<int>> combine(IList<IList<int>> l1, IList<IList<int>> l2)
//    {
//        List<IList<int>> result = new List<IList<int>>();

//        foreach (var i1 in l1)
//        {
//            foreach (var i2 in l2)
//            {
//                var newList = new List<int>();

//                newList.AddRange(i1);
//                newList.AddRange(i2);

//                result.Add(newList);
//            }
//        }

//        return result;
//    }
//}