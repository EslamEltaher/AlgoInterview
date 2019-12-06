////37 https://codeforces.com/problemset/problem/467/A

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
//            int[][] rooms = new int[n][];

//            for (int i = 0; i < n; i++)
//                rooms[i] = Array.ConvertAll(Console.ReadLine().Split(' '), el => Convert.ToInt32(el));

//            int output = getRooms(rooms);

//            Console.WriteLine(output);
//        }

//        static int getRooms(int[][] rooms)
//        {
//            int count = 0;

//            for (int i = 0; i < rooms.Length; i++)
//            {
//                if (rooms[i][1] - rooms[i][0] > 1)
//                    count++;
//            }

//            return count;
//        }
//    }
//}