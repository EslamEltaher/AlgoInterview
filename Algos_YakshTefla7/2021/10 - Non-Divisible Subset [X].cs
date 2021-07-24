//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//namespace Algos_YakshTefla7._2021
//{

//    class Result
//    {

//        /*
//         * Complete the 'nonDivisibleSubset' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER k
//         *  2. INTEGER_ARRAY s
//         */

//        public static int nonDivisibleSubset(int k, List<int> s)
//        {
//            /// 1 7 2 4     k =3  (1, 1, 2, 1)
//            //[0, 3, 1]
//            //3 * 3 + 3 * 2 = 12;

//            //[0, 2, 1]
//            //12 - 3 = 9
//            int result = s.Count;

//            int[] rems = new int[k];
//            int sum = 0;
//            int weights = 0;

//            for (int i = 0; i < s.Count; i++)
//            {
//                int rem = s[i] % k;
//                rems[rem]++;
//                sum += rem * (s.Count - 1);
//                weights += rem;
//                sum %= k;
//            }

//            if (sum != 0)
//                return result;

//            int last = 0;

//            //while(result > rems[0])
//            //{
//            //    int othersCount = result - 1;
//            //    for (int i = 1; i < k; i++)
//            //    {
//            //        if(rems[i] > 0)
//            //        {
//            //            last = i;

//            //            int x = sum - (weights - i) - (othersCount * i);
//            //            if (x % k != 0)
//            //            {
//            //                return result - 1;
//            //            }
//            //        }
//            //    }

//            //    if(last != 0)
//            //    {
//            //        sum -= (weights - last) + (last * othersCount);
//            //        weights -= last;
//            //        sum %= k;
//            //        result--;
//            //        rems[last]--;
//            //    }
//            //}

//            //if (result == rems[0])
//            //    return 0;


//            int othersCount = result - 1;

//            int min = result;
//            for (int i = 1; i < k; i++)
//            {
//                int count = 1;
//                int x = sum;
//                int w = weights;
//                while (count <= rems[i] && x % k == 0)
//                {
//                    w -= i;
//                    x = x - w - ((result - count) * i);
//                    count++;
//                }

//                if (x % k != 0)
//                    count--;

//                if (count < min && count <= rems[i])
//                    min = count;
//            }

//            result -= min;

//            if (result == rems[0])
//                return 0;

//            return result;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(firstMultipleInput[0]);

//            int k = Convert.ToInt32(firstMultipleInput[1]);

//            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

//            int result = Result.nonDivisibleSubset(k, s);

//            //textWriter.WriteLine(result);

//            //textWriter.Flush();
//            //textWriter.Close();
//        }
//    }

//}
