////https://www.hackerrank.com/challenges/maximum-palindromes/problem

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
//         * Complete the 'initialize' function below.
//         *
//         * The function accepts STRING s as parameter.
//         */

//        public static void initialize(string s)
//        {
//            // This function is called once before all queries.
//            Letters = new int[26][];
//            for (int i = 0; i < 26; i++)
//                Letters[i] = new int[s.Length];

//            Letters[s[0] - 'a'][0]++;

//            facts = new int[s.Length];

//            for (int i = 1; i < s.Length; i++)
//            {
//                for (int j = 0; j < 26; j++)
//                {
//                    Letters[j][i] = Letters[j][i - 1];
//                }
//                Letters[s[i] - 'a'][i]++;
//            }

//            lCounts = new int[s.Length, s.Length];
//            rCounts = new int[s.Length, s.Length];
//        }

//        /*
//         * Complete the 'answerQuery' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER l
//         *  2. INTEGER r
//         */

//        private static int[][] Letters;
//        private static int[,] lCounts;
//        private static int[,] rCounts;

//        public static int answerQuery(int l, int r)
//        {
//            // Return the answer for this query modulo 1000000007.
//            int[] letters = new int[26];

//            for (int i = 0; i < 26; i++)
//            {
//                if (l == 1)
//                    letters[i] = Letters[i][r - 1];
//                else
//                    letters[i] = Letters[i][r - 1] - Letters[i][l - 2];
//            }

//            bool[] odds = new bool[26];
//            int oddCount = 0;

//            for (int i = 0; i < letters.Length; i++)
//            {
//                if (letters[i] % 2 == 1)
//                {
//                    odds[i] = true;
//                    oddCount++;
//                }

//                letters[i] /= 2;
//            }

//            //20 A 5 B
//            //ABA ABBA ABBBA ABBBBA ABBBBA AABAA AABBAA  AABABAA
//            int[] counts = new int[26];

//            //determine the maximum length for palindrome

//            ////Approach 1
//            //int evens = CountLetter(letters, -1, counts);

//            //Approach 2
//            //int evens = countEvens(letters, counts);
//            //evens %= 1000000007;

//            //Approach 3
//            int evens = countEvens3(letters);
//            evens %= 1000000007;


//            oddCount = oddCount == 0 ? 1 : oddCount;
//            int result = evens * oddCount;
//            //for (int i = 0; i < 26; i++)
//            //{
//            //    if (odds[i] && counts[i] > 0)
//            //        result -= counts[i] - 1;
//            //}
//            return ((result % 1000000007) + 1000000007) % 1000000007;
//        }
//        public static int countEvens(int[] letters, int[] counts)
//        {
//            // Return the answer for this query modulo 1000000007.
//            int result = 1;
//            int l = -1;

//            for (int i = 0; i < letters.Length; i++)
//            {
//                if (letters[i] > 0)
//                {
//                    l = i;
//                    break;
//                }
//            }

//            for (int i = l + 1; i < 26; i++)
//            {
//                if (letters[i] > 0)
//                {
//                    int oldResult = result;
//                    result = letters[i] * (result + 1);

//                    counts[i] = letters[i] * result;
//                    counts[i] %= 1000000007;

//                    if (i > 0)
//                    {
//                        for (int j = i - 1; j >= 0; j--)
//                        {
//                            counts[j] *= oldResult;
//                            //counts[j] *= letters[i];
//                            counts[j] %= 1000000007;
//                        }
//                    }

//                    result %= 1000000007;
//                }
//            }

//            return result %= 1000000007;
//        }
//        public static int countEvens2(int[] letters, int[] counts)
//        {
//            // Return the answer for this query modulo 1000000007.
//            int result = 1;
//            int l = -1;
//            int len = 0;

//            for (int i = 0; i < letters.Length; i++)
//            {
//                if (letters[i] > 0)
//                {
//                    l = i;
//                    len = letters[i];
//                    counts[i] = 1;
//                    break;
//                }
//            }

//            for (int i = l + 1; i < 26; i++)
//            {
//                if (letters[i] > 0)
//                {
//                    int oldResult = result;

//                    //result = letters[i] * (result + 1);
//                    //counts[i] = letters[i] * result;

//                    int lCount;
//                    int rCount;
//                    int combinations = getCombinations(len, letters[i], out lCount, out rCount);

//                    result = combinations * oldResult;
//                    len += letters[i];

//                    counts[i] = rCount * oldResult;
//                    counts[i] %= 1000000007;

//                    if (i > 0)
//                    {
//                        for (int j = i - 1; j >= 0; j--)
//                        {
//                            counts[j] *= lCount;
//                            //counts[j] *= letters[i];
//                            counts[j] %= 1000000007;
//                        }
//                    }

//                    result %= 1000000007;
//                }
//            }

//            return result %= 1000000007;
//        }

//        public static int countEvens3(int[] letters)
//        {
//            //int f = 1;
//            Array.Sort(letters);
//            int length = letters[25];
//            for (int i = 24; i >= 0; i--)
//            {
//                length += letters[i];
//                //int factL = fact(letters[i]);

//                //factL %= 1000000007;
//                //f *= factL;
//                //f %= 1000000007;
//            }

//            int factAll = factFromTo(length, letters[25]) % 1000000007;

//            for (int i = 24; i >= 0; i--)
//            {
//                length += letters[i];
//                int factL = fact(letters[i]);

//                factAll = modDiv(factAll, factL, 1000000007);
//                //factL %= 1000000007;
//                //f *= factL;
//                //f %= 1000000007;
//            }

//            //return modDiv(factAll, f, 1000000007);
//            return factAll;

//        }
//        private static int[] facts;
//        private static int fact(int n)
//        {
//            if (n == 1 || n == 0)
//                return 1;

//            if (facts[n] <= 0)
//            {
//                facts[n] = (n % 1000000007) * fact(n - 1);
//                facts[n] %= 1000000007;
//            }
//            return facts[n];
//        }
//        private static int factFromTo(int n, int m)
//        {
//            if (n == m)
//                return 1;

//            return ((n % 1000000007) * (factFromTo(n - 1, m) % 1000000007)) % 1000000007;
//        }

//        private static int modDiv(int a, int b, int m)
//        {
//            a = a % m;
//            int inv = modInverse(b, m);
//            if (inv == -1)
//                return 0;
//            int c = (inv * a) % m;

//            return c;
//        }

//        private static int modInverse(int b, int m)
//        {
//            int x = 0, y = 0; // used in extended GCD algorithm
//            int g = gcdExtended(b, m, ref x, ref y);

//            // Return -1 if b and m are not co-prime
//            if (g != 1)
//                return -1;

//            // m is added to handle negative x
//            return (x % m + m) % m;
//        }

//        private static int gcdExtended(int a, int b, ref int x, ref int y)
//        {
//            // Base Case
//            if (a == 0)
//            {
//                x = 0;
//                y = 1;
//                return b;
//            }

//            int x1 = 0, y1 = 0; // To store results of recursive call
//            int gcd = gcdExtended(b % a, a, ref x1, ref y1);

//            // Update x and y using results of recursive
//            // call
//            x = y1 - (b / a) * x1;
//            y = x1;

//            return gcd;
//        }

//        public static int getCombinations(int l, int r, out int lCount, out int rCount)
//        {
//            if (l == 1)
//            {
//                lCount = 1;
//                rCount = r;
//                return r + 1;
//            }
//            else if (r == 1)
//            {
//                lCount = l;
//                rCount = 1;
//                return l + 1;
//            }

//            int max = Math.Max(l, r);
//            int min = Math.Min(l, r);

//            int x;
//            int y;

//            int maxCount, minCount;
//            if (lCounts[max, min] > 0)
//            {
//                maxCount = lCounts[max, min];
//                minCount = rCounts[max, min];
//            }
//            else
//            {
//                maxCount = getCombinations(max - 1, min, out x, out y);
//                minCount = getCombinations(max, min - 1, out x, out y);
//            }

//            if (max == l)
//            {
//                lCount = maxCount;
//                rCount = minCount;

//            }
//            else
//            {
//                lCount = minCount;
//                rCount = maxCount;

//            }
//            lCounts[max, min] = maxCount;
//            rCounts[max, min] = minCount;

//            return lCount + rCount;
//        }
//        //public static int answerQueryTwo(int l, int r)
//        //{
//        //    // Return the answer for this query modulo 1000000007.
//        //    int[] letters = new int[26];

//        //    for (int i = l - 1; i <= r - 1; i++)
//        //        letters[S[i] - 'a']++;

//        //    for (int i = 0; i < 26; i++)
//        //    {

//        //    }

//        //    int result = 1;

//        //    l = -1;
//        //    for (int i = 0; i < letters.Length; i++)
//        //    {
//        //        if (letters[i] > 0)
//        //        {
//        //            l = i;
//        //            break;
//        //        }
//        //    }

//        //    for (int i = l + 1; i < 26; i++)
//        //    {
//        //        if (letters[i] > 0)
//        //        {
//        //            result = letters[i] * (result + 1);

//        //            result %= 1000000007;
//        //        }
//        //    }

//        //    return result %= 1000000007;
//        //}

//        public static int CountLetter(int[] letters, int l, int[] counts)
//        {
//            int count = 0;
//            for (int i = 0; i < letters.Length; i++)
//            {
//                if (letters[i] > 0)
//                {
//                    letters[i]--;
//                    int letterCount = CountLetter(letters, i, null);
//                    letterCount %= 1000000007;
//                    if (counts != null)
//                        counts[i] = letterCount;
//                    count += letterCount;
//                    letters[i]++;
//                    count %= 1000000007;
//                }
//            }
//            return count > 0 ? count : 1;
//        }

//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//            //TextWriter textWriter = new StreamWriter(new MemoryStream());

//            string s = Console.ReadLine();

//            Result.initialize(s);

//            int q = Convert.ToInt32(Console.ReadLine().Trim());

//            for (int qItr = 0; qItr < q; qItr++)
//            {
//                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//                int l = Convert.ToInt32(firstMultipleInput[0]);

//                int r = Convert.ToInt32(firstMultipleInput[1]);

//                int result = Result.answerQuery(l, r);

//                textWriter.WriteLine(result);
//            }

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
