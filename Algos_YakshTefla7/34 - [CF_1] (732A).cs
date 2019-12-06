//// 34 CodeForces Buy A Shovel https://codeforces.com/problemset/problem/732/a

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algos_YakshTefla7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), el => Convert.ToInt32(el));
//            int output = buyAShovel(input[0], input[1]);

//            Console.WriteLine(output);
//        }

//        //117 3
//        //9
//        static int buyAShovel(int k, int r)
//        {
//            //k = 117 //r = 3
//            int x = 1;
//            int k10 = k % 10;
//            int r10 = r % 10;

//            if ((k10 % 2 == 0) && (r10 % 2 == 1))
//                return 10;

//            if (k10 == r10)
//                return 1;

//            if (k10 == 2 && r10 % 2 == 0)
//                return k10 / r10;

//            while (true)
//            {

//                #region Ones & Tens
//                ////03
//                ////13
//                ////23
//                ////33
//                ////43
                
//                //int cost = 10 * x + r;

//                //if (cost % k == 0)
//                //    return cost / k;
//                #endregion

//                #region Number of flowers
//                int cost = x * k;

//                if ((cost - r) % 10 == 0)
//                    return x;
//                #endregion


//                x++;
//            }
//        }
//    }
//}