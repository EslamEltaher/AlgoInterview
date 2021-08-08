//https://app.codility.com/cert/view/certA5G4GT-H8G4TSCWX2FE42M8/details/

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Algos_YakshTefla7._2021
{
    class Solution
    {
        public int[] solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] newArr = new int[A.Length];
            var sums = new System.Collections.Generic.Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!sums.ContainsKey(i / 3))
                {
                    sums.Add(i / 3, 0);
                }
                sums[i / 3] += A[i];

                if (!sums.ContainsKey((i % 3) + 3))
                {
                    sums.Add((i % 3) + 3, 0);
                }

                sums[(i % 3) + 3] += A[i];

                newArr[i] = A[i];
            }

            int max = sums[0];
            for (int i = 1; i < 6; i++)
            {
                if (sums[i] > max)
                    max = sums[i];
            }


            for (int i = 0; i < 9; i++)
            {
                int row = i / 3;
                int col = (i % 3) + 3;
                if (sums[row] < max && sums[col] < max)
                {
                    int diff = max - Math.Max(sums[col], sums[row]);

                    newArr[i] += diff;
                    sums[row] += diff;
                    sums[col] += diff;
                }
            }

            return newArr;
        }
    }

}
