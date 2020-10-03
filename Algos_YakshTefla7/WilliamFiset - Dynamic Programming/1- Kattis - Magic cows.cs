////https://open.kattis.com/problems/magicalcows


/// WRONG
///  https://www.youtube.com/watch?v=_tur2nPkIKo


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Solution
//{
//    public static int[] MagicalCows(int C, int[] initialFarms, int[] vists)
//    {
//        int[] farms = new int[vists.Length];

//        for (int i = 0; i < vists.Length; i++)
//        {
//            int day = vists[i];

//            int sum = 0;
//            for (int j = 0; j < initialFarms.Length; j++)
//            {
//                sum += initialFarms[j] * (int)Math.Pow(2, (double)day);
//            }

//            int numberOfFarms = (sum / C);
//            if(sum % C != 0)
//            {
//                numberOfFarms++;
//            }

//            if (numberOfFarms < initialFarms.Length)
//                numberOfFarms = initialFarms.Length;

//            farms[i] = numberOfFarms;
//        }

//        return farms;
//    }



//    public static void Main(string[] args)
//    {
//        int[] cnm = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
//        int C = cnm[0]; //max number of cows
//        int N = cnm[1]; //number of farms on Day 0
//        int M = cnm[2]; // the number of different days on which the Regulator visits

//        int[] initialFarms = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            initialFarms[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int[] visits = new int[M];
//        for (int i = 0; i < M; i++)
//        {
//            visits[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        var result = MagicalCows(C, initialFarms, visits);

//        for (int i = 0; i < result.Length; i++)
//            Console.WriteLine(result[i]);

//        Console.ReadLine();
//    }
//}
