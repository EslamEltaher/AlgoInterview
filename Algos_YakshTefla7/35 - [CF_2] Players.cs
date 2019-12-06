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
//            int output = MakeATeam(input[0], input[1], input[2]);

//            Console.WriteLine(output);
//        }

//        static int MakeATeam(int l, int r, int a)
//        {
//            int x = Math.Min(l, r);
//            int diff = Math.Abs(l - r);

//            if (diff > a)
//                return 2 * (x + a);

//            return 2 * (x + diff + ((a - diff) / 2));
//        }
//    }
//}