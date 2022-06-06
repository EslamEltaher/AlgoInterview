////1 - 1 https://leetcode.com/contest/weekly-contest-296/
////1 - 1 https://leetcode.com/contest/weekly-contest-296/problems/min-max-game

//public class Solution
//{
//    public int MinMaxGame(int[] nums)
//    {
//        int n = nums.Length / 2;
//        var arr = nums;

//        while (arr.Length > 1)
//        {
//            arr = recurs(arr);
//        }
//        return arr[0];

//    }

//    public int[] recurs(int[] nums)
//    {
//        var n = nums.Length / 2;

//        int[] arr = new int[n];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (i % 2 == 0)
//                arr[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);
//            else
//                arr[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
//        }

//        return arr;
//    }
//}