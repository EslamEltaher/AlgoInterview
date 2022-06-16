////https://leetcode.com/problems/subsets/

//using System.Collections.Generic;

//public class Solution
//{
//    public IList<IList<int>> Subsets(int[] nums)
//    {
//        return Subsets(nums, 0, nums.Length - 1);
//    }

//    public IList<IList<int>> Subsets(int[] nums, int left, int right)
//    {
//        //if (left > nums.Length - 1)
//        //    return new List<IList<int>>() { new List<int>() };

//        //var result = new List<IList<int>>();

//        //if(left == right)
//        //{
//        //    result.Add(new List<int>() { nums[left] });
//        //    return result;
//        //}

//        //var list = new List<int>();

//        //int i = left;
//        //int j = right;

//        //while (i <= j)
//        //{
//        //    list.Add(nums[i++]);
//        //}
//        //result.Add(list);

//        //result.AddRange(Subsets(nums, left, right - 1));
//        //result.AddRange(Subsets(nums, left + 1, right));

//        ////while(right > left)
//        ////    result.AddRange(Subsets(nums, left, --right));
//        ///

//        if(left == right)
//        {
//            return new List<IList<int>>() { new List<int>(), new List<int>() { nums[left] } };
//        }
//        var ans = new List<IList<int>>();
//        var results = Subsets(nums, left + 1, right);

//        foreach (var res in results)
//        {
//            var newResult = new List<int>() { nums[left] };
//            newResult.AddRange(res);

//            ans.Add(res);
//            ans.Add(newResult);
//        }

//        return ans;
//    }
//}