//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Algos_YakshTefla7
//{
//    class Solution
//    {
//        public int solution(int N)
//        {
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//            var binary = getBinary(N);

//            int maxGap = 0;
//            //int currentGap = 0;
//            //char previous = '0';
//            //for (int i = 0; i < binary.Length; i++)
//            //{
//            //    if(binary[i] == '1')
//            //    {
//            //        if (previous == '0' && binary[i] == '1' && currentGap > maxGap)
//            //        {
//            //            maxGap = currentGap;
//            //            currentGap = 0;
//            //        }
//            //    }
//            //    else
//            //    {
//            //        if (currentGap > 1)
//            //            currentGap++;

//            //        if(previous == '1')
//            //        {
//            //            currentGap = 1;
//            //        }
//            //    }

//            int currentGap = 0;
//            int OneAt = -1;

//            for (int i = 0; i < binary.Length; i++)
//            {
//                if (binary[i] == '1')
//                {
//                    if (OneAt != -1)
//                    {
//                        int gap = i - OneAt - 1;
//                        if (gap > maxGap)
//                            maxGap = gap;
//                    }
//                    OneAt = i;
//                }
//            }


//            return maxGap;
//        }

//        string getBinary(int N)
//        {
//            string binary = "";
//            while(N > 0)
//            {
//                if (N % 2 == 0)
//                    binary = "0" + binary;
//                else
//                    binary = "1" + binary;

//                N /= 2;
//            }

//            return binary;
//        }
//    }
//}
