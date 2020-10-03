////30
//using System.Collections.Generic;
//using System;

//class Solution
//{

//    // Complete the pylons function below.
//    static int countPairs(int k, int[] arr)
//    {
//        var num = new HashSet<int>();

//        for (int i = 0; i < arr.Length; i++)
//            num.Add(arr[i]);

//        int count = 0;

//        foreach(var x in num)
//        {
//            Console.WriteLine("num:" + x);
//            if (num.Contains(x + k))
//                count++;
//        }

//        return count;
//    }

//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int k = Convert.ToInt32(Console.ReadLine());

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int result = countPairs(k, arr);

//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
