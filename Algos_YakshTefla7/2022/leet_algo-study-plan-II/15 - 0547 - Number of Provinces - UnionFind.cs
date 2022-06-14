////https://leetcode.com/problems/number-of-provinces/

//using System.Collections.Generic;

//public class Solution
//{
//    public int FindCircleNum(int[][] isConnected)
//    {
//        int n = isConnected.Length;

//        int[] parents = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            parents[i] = i;
//        }

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = i; j < n; j++)
//            {
//                if (i == j)
//                    continue;

//                if(isConnected[i][j] == 1)
//                    union(parents, i, j);
//            }
//        }

//        //get top most parents for all
//        for(int i = 0; i < parents.Length; i++)
//        {
//            parents[i] = getTopMostParent(parents, i);
//        }

//        HashSet<int> set = new HashSet<int>();

//        for(int i = 0; i < parents.Length; i++)
//        {
//            if (!set.Contains(parents[i]))
//                set.Add(parents[i]);
//        }

//        return set.Count;
//    }

//    public void union(int[] parents, int i, int j)
//    {
//        int iTop = getTopMostParent(parents, i);
//        int jTop = getTopMostParent(parents, j);

//        parents[i] = iTop;
//        parents[j] = jTop;

//        if(iTop == i)
//            parents[jTop] = iTop;
//        else
//            parents[iTop] = jTop;
//    }

//    private int getTopMostParent(int[] parents, int index)
//    {
//        while (parents[index] != index)
//            index = parents[index];

//        return index;
//    }
//}