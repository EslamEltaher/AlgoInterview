////https://leetcode.com/problems/number-of-provinces/

//using System;
//using System.Collections.Generic;

//public class Solution
//{
//    public int FindCircleNum(int[][] isConnected)
//    {
//        int num = 0;
//        int[] visited = new int[isConnected.Length];

//        for(int i = 0; i < isConnected.Length; i++)
//        {
//            if(visited[i] == 0)
//            {
//                DFS(isConnected, i, visited);

//                visited[i] = 1;

//                num++;
//            }
//        }

//        return num;
//    }

//    private void DFS(int[][] isConnected, int i, int[] visited)
//    {
//        for (int j = 0; j < isConnected.Length; j++)
//        {
//            if (visited[j] == 0 && isConnected[i][j] == 1)
//            {
//                visited[j] = 1;

//                DFS(isConnected, j, visited);
//            }
//        }
//    }
//}