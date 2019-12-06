////38 https://codeforces.com/problemset/problem/427/a

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
//            int n = Convert.ToInt32(Console.ReadLine());
//            int[] events = Array.ConvertAll(Console.ReadLine().Split(' '), el => Convert.ToInt32(el));

//            int result = numberOfCrimes(events);
//            Console.WriteLine(result);
//        }

//        static int numberOfCrimes(int[] events)
//        {
//            int crimes = 0;
//            int actualCrimes = 0;
//            int policers = 0;

//            for (int i = 0; i < events.Length; i++)
//            {
//                if(events[i] == -1)
//                {
//                    crimes = 1;
//                    if(policers == 0)
//                        actualCrimes += crimes;
//                    else
//                    {
//                        crimes = 0;
//                        policers--;
//                    }
//                }

//                if (events[i] > 0)
//                {
//                    policers += events[i];
//                }
//            }

//            return actualCrimes;
//        }
//    }
//}