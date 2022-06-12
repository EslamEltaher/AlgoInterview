////https://leetcode.com/problems/search-a-2d-matrix/

//public class Solution
//{
//    public bool SearchMatrix(int[][] matrix, int target)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            int n = matrix[i].GetLength(0);

//            for(int j = 0; j < n; j++)
//            {
//                if (matrix[i][j] == target)
//                    return true;
//            }

//            if (matrix[i][n - 1] > target)
//            {
//                return false;
//            }
//        }

//        return false;
//    }
//}