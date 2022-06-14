////https://leetcode.com/problems/number-of-islands/

///// Should be DFS 
///// I Solved it with Union-Find

//using System.Collections.Generic;

//public class Solution
//{
//    public int NumIslands(char[][] grid)
//    {
//        int m = grid.Length;
//        int n = grid[0].Length;

//        #region DFS
//        var visited = new HashSet<int>();
//        int islands = 0;

//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                int index = n * i + j;

//                if (grid[i][j] == '1' && !visited.Contains(index))
//                {
//                    DFS(grid, i, j, visited);

//                    islands++;
//                    visited.Add(index);
//                }

//            }
//        }

//        return islands;
//        #endregion
//    }

//    public void DFS(char[][] grid, int i, int j, HashSet<int> visited)
//    {

//        int m = grid.Length;
//        int n = grid[0].Length;

//        int index = n * i + j;

//        if (i >= 0 && j >= 0
//            && i < m && j < n
//            && grid[i][j] == '1'
//            && !visited.Contains(index))
//        {
//            visited.Add(index);

//            int[][] directions = new int[][] {
//                new int [] { -1,0 },
//                new int [] { 1,0 },
//                new int [] { 0,-1 },
//                new int [] { 0, 1 }
//            };

//            for (int k = 0; k < directions.Length; k++)
//            {
//                DFS(grid, i + directions[k][0], j + directions[k][1], visited);
//            }
//        }
//    }


//}

////public class prog
////{
////    public static void Main(string[] args)
////    {
////        var arr = new char[][] {
////            new char[]{ '1', '1', '1', '1', '0' },
////            new char[]{ '1', '1', '0', '1', '0' },
////            new char[]{ '1', '1', '0', '0', '0' },
////            new char[]{ '0', '0', '0', '0', '0' }
////        };
////        arr = new char[][] {
////            new char [] { '1','1','1','1','1','0','1','1','1','1'},
////            new char [] { '1','0','1','0','1','1','1','1','1','1'},
////            new char [] { '0','1','1','1','0','1','1','1','1','1'},
////            new char [] { '1','1','0','1','1','0','0','0','0','1'},
////            new char [] { '1','0','1','0','1','0','0','1','0','1'},
////            new char [] { '1','0','0','1','1','1','0','1','0','0'},
////            new char [] { '0','0','1','0','0','1','1','1','1','0'},
////            new char [] { '1','0','1','1','1','0','0','1','1','1'},
////            new char [] { '1','1','1','1','1','1','1','1','0','1'},
////            new char [] { '1','0','1','1','1','1','1','1','1','0'}
////        };

////        var x = new Solution().NumIslands(arr);
////    }
////}