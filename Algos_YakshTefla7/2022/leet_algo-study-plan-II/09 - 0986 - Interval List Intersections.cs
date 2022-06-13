////https://leetcode.com/problems/interval-list-intersections/

//using System;

//public class Solution
//{
//    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
//    {
//        if (firstList.Length == 0 || secondList.Length == 0)
//            return new int[0][];

//        System.Collections.Generic.List<int[]> result = new System.Collections.Generic.List<int[]>();

//        int first = 0;
//        int second = 0;

//        while(first < firstList.Length && second < secondList.Length)
//        {
//            //how to detect intersection
//            //1. Case 1
//            //   |   |
//            // |   |
//            //secondEnd <= FirstStart && secondStart >= FirstStart
//            //
//            //2. Case 2
//            //  |   |
//            //     |   |
//            //secondStart <= FirstEnd && secondEnd >= FirstStart
//            //
//            //to get Intersection
//            //We choose max start and min end
//            // A |   |
//            // B   |    |
//            // C   | |              <--- Intersection
            
//            int maxStart = Math.Max(firstList[first][0], secondList[second][0]);
//            int minEnd = Math.Min(firstList[first][1], secondList[second][1]);

//            if(maxStart <= minEnd)
//            {
//                result.Add(new int[] { maxStart, minEnd });
//            }


//            //we move forward with the pointer with the smaller EndPoint 
//            if (firstList[first][1] < secondList[second][1])
//                first++;

//            else
//                second++;
//        }

//        return result.ToArray();
//    }
//}