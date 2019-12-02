////31 https://www.hackerrank.com/challenges/non-divisible-subset/problem
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


//class Result
//{

//    /*
//     * Complete the 'nonDivisibleSubset' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts following parameters:
//     *  1. INTEGER k
//     *  2. INTEGER_ARRAY s
//     */

//    //////////////////////////////////////////////////////////////// 5/17 Test Cases Timeout
//    public static int nonDivisibleSubset(int k, int[] mods)
//    {
//        //converting to MODS
//        for(int i = 0; i < mods.Length; i++)
//            mods[i] = mods[i] % k;

//        Array.Sort(mods);

//        int sLength = mods.Length;

//        int left = 0;
//        int right = mods.Length - 1;

//        //if all have mod 0 all mutations don't make non-divisible
//        //also protects following while from IndexOutOfRange
//        if (mods[mods.Length - 1] == 0)
//            return 1;

//        while (mods[left] == 0)
//        {
//            //to delete all occurances of 0 except 1
//            if (mods[left + 1] == 0)
//                sLength--;

//            left++;
//        }

//        while(right > left)
//        {
//            if (mods[left] + mods[right] == k)
//            {
//                int countLeft = 1;
//                int countRight = 1;
//                while (mods[left + 1] == mods[left] && left + 1 < right)
//                {
//                    left++;
//                    countLeft++;
//                }

//                while (mods[right - 1] == mods[right] && right - 1 > left)
//                {
//                    right--;
//                    countRight++;
//                }

//                //if both are equal (K/2)
//                if(mods[left] == mods[right])
//                {
//                    sLength -= (countRight + countLeft - 1);
//                }
//                else if (countRight < countLeft)
//                {
//                    right --;
//                    sLength -= countRight;
//                }
//                else if (countLeft < countRight)
//                {
//                    left++;
//                    sLength -= countLeft;
//                }

//            }
//            else  // can't be outside else because shifting is determined in previous step
//            {
//                if (mods[left] + mods[right] > k)
//                    right--;
//                else
//                    left++;
//            }
//        }

//        return sLength;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//        int n = Convert.ToInt32(firstMultipleInput[0]);

//        int k = Convert.ToInt32(firstMultipleInput[1]);

//        int[] s = Console.ReadLine().TrimEnd().Split(' ').Select(sTemp => Convert.ToInt32(sTemp)).ToArray();

//        int result = Result.nonDivisibleSubset(k, s);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
