////30
//using System.Collections.Generic;
//using System;
//using System.Net.Http;

//class Solution
//{
//    static int SplitTheArray(int[] val)
//    {
//        int count = 0;

//        for (int i = 0; i < val.Length; i += 2)
//        {
//            for (int j = i + 1; j < val.Length; j++)
//            {
//                if (GCD(val[i], val[j]) > 1)
//                {
//                    swap(val, i + 1, j);
//                    count++;
//                    break;
//                }
//            }
//        }

//        return count;
//    }
//    static int GCD(int x, int y)
//    {
//        int gcd = 1;

//        int cd = 2;

//        while (cd <= x && cd <= y)
//        {
//            if (x % cd == 0 && y % cd == 0)
//            {
//                gcd *= cd;
//                x /= cd;
//                y /= cd;
//            }
//            else
//            {
//                cd += 1;
//            }
//        }

//        return gcd;
//    }
//    static void swap(int[] arr, int i, int j)
//    {
//        int temp = arr[i];
//        arr[i] = arr[j];
//        arr[j] = temp;
//    }
//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] val = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            val[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int result = SplitTheArray(val);


//        #region trying GCD
//        //int n = Convert.ToInt32(Console.ReadLine());
//        //int k = Convert.ToInt32(Console.ReadLine());
//        //var result = GCD(n, k);
//        #endregion

//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
