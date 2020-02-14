////40 https://codeforces.com/problemset/problem/294/a

//using System;
//using System.Collections.Generic;
////using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace algos_yakshtefla7
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            int[] wiresBefore = Array.ConvertAll(Console.ReadLine().Split(' '), el => Convert.ToInt32(el));
//            int m = Convert.ToInt32(Console.ReadLine());
//            int[][] events = new int[m][];
//            for (int i = 0; i < m; i++)
//            {
//                events[i] = Array.ConvertAll(Console.ReadLine().Split(' '), el => Convert.ToInt32(el));
//            }
//            int[] wires = getWires(wiresBefore, events);        //the actual function
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(wires[i]);
//            }
//            //Console.ReadLine();
//        }
//        static int[] getWires(int[] w, int[][] events)
//        {
//            for (int i = 0; i < events.Length; i++)
//            {
//                int x = events[i][0] - 1;
//                int y = events[i][1] - 1;

//                //left i-1
//                //w[x] = 0;
//                if(x - 1 > 0)
//                {
//                    w[x - 1] += y;
//                }
                
//                //right i+1
//                if(x + 1 < w.Length)
//                {
//                    w[x + 1] += w[x] - (y + 1);
//                }

//                w[x] = 0;
//            }
//            return w;
//        }
//    }
//}