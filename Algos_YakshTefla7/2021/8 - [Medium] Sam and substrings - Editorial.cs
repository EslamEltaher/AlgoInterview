////https://www.hackerrank.com/challenges/sam-and-substrings/problem


////Editorial Opened
////A little hint: the constraint is written in an ambiguous way.
////1 <= ncasatsinteger <= 2 * 10 ^ 5
////the variable "ncastasinteger" might be interpreted that the string value is less than 200000 which would mean the length of the string is 6 at maximum
////I spent hours on this assumptions until someone clarified it in description

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
//         * Complete the 'substrings' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts STRING n as parameter.
//         */

//        public static int substrings(string n)
//        {
//            //int sum = 0;
//            //for (int i = 0; i < n.Length; i++)
//            //{
//            //    int current = 0;
//            //    for (int j = i; j < n.Length; j++)
//            //    {
//            //        current = ((current * 10) + n[j] - 48) % 1000000007;
//            //        sum += current;
//            //    }
//            //}
//            ////sum = sum % 1000000007;
//            ///

//            //////////////////////////////////////////////////////

//            //Solution 2 (Attempt 2)
//            //example '123'(1, 12, 123, 2, 23, 3) = (1 + 10 + 100) + 2 * (2 + 20) + 3 * 3

//            //int sum = 0;

//            //int[] ones = new int[n.Length];  // [1,11,111,1111,11111,111111]
//            //ones[0] = 1;
//            //for (int i = 1; i < ones.Length; i++)
//            //{
//            //    ones[i] = (ones[i - 1] * 10) + 1;
//            //}

//            //for (int i = 0; i < n.Length; i++)
//            //{
//            //    int num = n[i] - '0';
//            //    int x = num * (i + 1) * ones[n.Length - 1 - i];
//            //    x = x % 1000000007;
//            //    sum += x;
//            //    sum = sum % 1000000007;
//            //}
//            //sum = sum % 1000000007;

//            //////////////////////////////////////////////////////
//            //geeks for geeks

//            //int sum = 0;

//            //int len = n.Length;

//            //// allocate memory equal to
//            //// length of string
//            //int[] sumofdigit = new int[len];

//            //// initialize first value
//            //// with first digit
//            //sumofdigit[0] = n[0] - '0';
//            //int res = sumofdigit[0];

//            //// loop over all digits
//            //// of string
//            //for (int i = 1; i < len; i++)
//            //{
//            //    int numi = n[i] - '0';

//            //    // update each sumofdigit
//            //    // from previous value
//            //    sumofdigit[i] = (i + 1) * numi + 10 * sumofdigit[i - 1];

//            //    // add current value
//            //    // to the result
//            //    res += sumofdigit[i] % 1000000007;
//            //}

//            //sum = res % 1000000007;



//            /// Solution 4: After Editorial
//            int sum = 0;
//            long[] vals = new long[n.Length];
//            vals[0] = n[0] - '0';
//            for(int i = 1; i < n.Length; i++)
//            {
//                vals[i] = (n[i] - '0') * (i + 1) + 10 * vals[i - 1];
//                vals[i] = vals[i] % 1000000007;
//            }

//            for(int i = 0; i < vals.Length; i++)
//            {
//                sum += (int)vals[i];
//                sum %= 1000000007;
//            }

//            return sum;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            string n = Console.ReadLine();

//            int result = Result.substrings(n);

//            textWriter.WriteLine(result);

//            textWriter.Flush(); 
//            textWriter.Close();
//        }
//    }

//}


//// Dynamic Programming