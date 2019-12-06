////36 https://codeforces.com/problemset/problem/371/b

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
//            int output = getDivisions(input[0], input[1]);

//            Console.WriteLine(output);
//        }

//        static int getDivisions(int x, int y)
//        {
//            int[] xx = getNumberDivsions(x);
//            int[] yy = getNumberDivsions(y);

//            if (xx[3] != yy[3])
//                return -1;

//            return 
//                Math.Abs(xx[0] - yy[0])
//                + Math.Abs(xx[1] - yy[1])
//                + Math.Abs(xx[2] - yy[2]);
//        }

//        static int[] getNumberDivsions(int x)
//        {
//            int[] nums = new int[4]; // { CountOf2s, CountOf3s, CountOf5s, remaining }

//            while(x > 1)
//            {
//                if (x % 2 == 0)
//                {
//                    nums[0]++;
//                    x /= 2;
//                }
//                else if(x % 3 == 0)
//                {
//                    nums[1]++;
//                    x /= 3;
//                }
//                else if (x % 5 == 0)
//                {
//                    nums[2]++;
//                    x /= 5;
//                }
//                else
//                {
//                    nums[3] = x;
//                    break;
//                }
//            }

//            return nums;
//        }
//    }
//}