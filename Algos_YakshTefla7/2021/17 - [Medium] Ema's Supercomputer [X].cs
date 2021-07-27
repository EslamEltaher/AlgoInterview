//https://www.hackerrank.com/challenges/two-pluses/problem
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Algos_YakshTefla7._2021
{

    class Result
    {

        /*
         * Complete the 'twoPluses' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING_ARRAY grid as parameter.
         */

        /// <summary>
        /// Attempt 1
        /// </summary>
        //public static int twoPluses(List<string> grid)
        //{
        //    int n = grid.Count;
        //    int m = grid[0].Length;

        //    int max1 = -1;
        //    int max2 = -1;

        //    int max1X = -1;
        //    int max1Y = -1;

        //    int max2X = -1;
        //    int max2Y = -1;

        //    for (int i = 0; i < n; i++)
        //    {
        //        int vert_Boundary = Math.Min(i + 1, n - i);

        //        for (int j = 0; j < m; j++)
        //        {
        //            int horz_Boundary = Math.Min(j + 1, m - j);

        //            // -1 to make it boundary of offset
        //            int boundary = Math.Min(vert_Boundary, horz_Boundary) - 1;

        //            if (grid[i][j] == 'G')
        //            {
        //                //check the max plus with the point as it's center
        //                int current = 0;
        //                bool overlaps1 = false;
        //                bool overlaps2 = false;
        //                bool stop = false;

        //                while (current + 1 <= boundary && !stop)
        //                {
        //                    int attempt = current + 1;

        //                    //check more than current
        //                    if (grid[i - attempt][j] == 'G'
        //                        && grid[i + attempt][j] == 'G'
        //                        && grid[i][j - attempt] == 'G'
        //                        && grid[i][j + attempt] == 'G'
        //                        )
        //                    {

        //                        //check it's not included in any others
        //                        if (pointIncluded(i - attempt, j, max1X, max1Y, max1)
        //                            || pointIncluded(i + attempt, j, max1X, max1Y, max1)
        //                            || pointIncluded(i, j - attempt, max1X, max1Y, max1)
        //                            || pointIncluded(i, j + attempt, max1X, max1Y, max1)
        //                            )
        //                            overlaps1 = true;

        //                        if (pointIncluded(i - attempt, j, max2X, max2Y, max2)
        //                            || pointIncluded(i + attempt, j, max2X, max2Y, max2)
        //                            || pointIncluded(i, j - attempt, max2X, max2Y, max2)
        //                            || pointIncluded(i, j + attempt, max2X, max2Y, max2))
        //                            overlaps2 = true;

        //                        current++;
        //                    }
        //                    else
        //                    {
        //                        stop = true;
        //                    }
        //                }

        //                if (current > max1 && (!overlaps1 || !overlaps2 || (current * 4 + 1) > (max1 * 4 + 1) * (max2 * 4 + 1)))
        //                {
        //                    max2 = max1;
        //                    max2X = max1X;
        //                    max2Y = max1Y;

        //                    max1 = current;
        //                    max1X = i;
        //                    max1Y = j;
        //                }
        //                else if (current > max2 && !overlaps1)
        //                {
        //                    max2 = current;
        //                    max2X = i;
        //                    max2Y = j;
        //                }
        //            }
        //        }
        //    }

        //    if (max2 == -1)
        //        return 0;

        //    max1 = 1 + 4 * max1;
        //    max2 = 1 + 4 * max2;

        //    return max1 * max2;
        //}


        //Attempt 2
        public static int twoPluses(List<string> grid)
        {
            int n = grid.Count;
            int m = grid[0].Length;

            int[][] cells = new int[n][];
            int[] values = new int[n * m];
            values[0] = grid[0][0] == 'G' ? 0 : -1;

            for (int i = 0; i < n; i++)
            {
                cells[i] = new int[m];

                int vert_Boundary = Math.Min(i + 1, n - i);

                for (int j = 0; j < m; j++)
                {
                    int horz_Boundary = Math.Min(j + 1, m - j);

                    // -1 to make it boundary of offset
                    int boundary = Math.Min(vert_Boundary, horz_Boundary) - 1;

                    int current = -1;
                    int index = i * n + j;
                    if (grid[i][j] == 'G')
                    {
                        //check the max plus with the point as it's center
                        current = 0;
                        bool stop = false;

                        while (current + 1 <= boundary && !stop)
                        {
                            int attempt = current + 1;

                            //check more than current
                            if (grid[i - attempt][j] == 'G'
                                && grid[i + attempt][j] == 'G'
                                && grid[i][j - attempt] == 'G'
                                && grid[i][j + attempt] == 'G'
                                )
                            {
                                current++;
                            }
                            else
                            {
                                stop = true;
                            }
                        }
                        //cells[i][j] = index;
                        values[index] = current;
                    }
                    else
                    {
                        values[index] = -1;
                    }
                }
            }

            int max1 = 0;
            int max2 = 0;

            int[] sortedVals = values.ToArray();
            Array.Sort(sortedVals);

            if (sortedVals[sortedVals.Length - 2] < 0)
                return 0;

            max1 = sortedVals[sortedVals.Length - 1];
            for (int itr = sortedVals.Length - 1; itr >= 0; itr--)
            {
                int value = sortedVals[itr];
                int index = Array.IndexOf(values, value);

                int X = index / n;
                int Y = index % n;

                int newVal = -1;
                for(int i = 0; i <= value; i++)
                {
                    int cell1 = cells[X - i][Y];
                    int cell2 = cells[X + i][Y];
                    int cell3 = cells[X][Y - i];
                    int cell4 = cells[X][Y + i];

                    if(values[cell1] <= i
                        && values[cell2] <= i
                        && values[cell3] <= i
                        && values[cell4] <= i)
                    {
                        newVal++;
                    }
                    else
                    {
                        i = value + 1; //break;
                    }
                }

                if(itr != sortedVals.Length - 1)
                {
                    if (newVal > max2)
                        max2 = newVal;
                }

                values[index] = newVal;

            }



            max1 = 1 + 4 * max1;
            max2 = 1 + 4 * max2;

            return max1 * max2;
        }
        public static bool pointIncluded(int pointX, int pointY, int plusX, int plusY, int plusOffset)
        {
            if (plusOffset == -1)
                return false;
            //included if (point X  = plusX and point Y = plusY +- offset)
            //         OR (point Y  = plusY and point X = plusX += offset)
            return (pointX == plusX && pointY <= plusY + plusOffset && pointY >= plusY - plusOffset)
                || (pointY == plusY && pointX <= plusX + plusOffset && pointX >= plusX - plusOffset);
        }
        public static bool linesIntersect(int L1X1, int L1Y1, int L1X2, int L1Y2, int L2X1, int L2Y1, int L2X2, int L2Y2)
        {
            return false;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            int result = Result.twoPluses(grid);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
