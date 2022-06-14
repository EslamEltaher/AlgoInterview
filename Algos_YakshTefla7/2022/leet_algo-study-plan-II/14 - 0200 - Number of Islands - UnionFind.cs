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

//        //array for adding the parent of each node
//        var parent = new int[n * m];

//        for (int i = 0; i < m; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                //creating an index to store the nodes parent in the array
//                int index = n * i + j;

//                //first assume the node is water and then its parent is -1
//                parent[index] = -1;


//                if (grid[i][j] != '1')
//                {
//                    continue;
//                }

//                //registering the node as its own parent assuming it's the only one in its island
//                parent[index] = index;

//                //if there is a node to the left
//                //we set the parent to current node to the left node's topmost parent
//                if (j > 0 && grid[i][j - 1] == '1')
//                {
//                    int leftIndex = n * i + j - 1;

//                    int leftIndexParent = getTopMostParent(parent, leftIndex);

//                    parent[parent[index]] = leftIndexParent;
//                }

//                //if there's a node upwards
//                if (i > 0 && grid[i - 1][j] == '1')
//                {
//                    int upIndex = n * (i - 1) + j;

//                    //if current node's parent is not itself this means it was set as the parent of the left node
//                    //then we set the topmost parent of the upward node to the topmost parent to the left node
//                    if (parent[index] != index)
//                    {
//                        //traversing parents of up index
//                        int upIndexParent = getTopMostParent(parent, upIndex);

//                        parent[upIndexParent] = parent[index];
//                    }
//                    else
//                    {
//                        //else we set the upward node as the parent node
//                        parent[index] = parent[upIndex];
//                    }
//                }
//            }
//        }


//        //each node has a parent set to it
//        //we set each nodes parent as the top most parent to its parent
//        //after that we will have in the array only the unique values of the topmost parents
//        //or in other words a unique index to each island
//        for (int i = 0; i < parent.Length; i++)
//        {
//            if(parent[i] != -1)
//            {
//                parent[i] = getTopMostParent(parent, i);
//            }
//        }
        
//        //we store the unique values of islands in a set
//        var set = new HashSet<int>();

//        foreach (var key in parent)
//        {
//            if (key != -1 && !set.Contains(key))
//                set.Add(key);
//        }


//        //we return the count of the unique parents in the set
//        return set.Count;
//    }

//    private int getTopMostParent(int[] arr, int index)
//    {
//        while (arr[index] != index)
//            index = arr[index];

//        return index;
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