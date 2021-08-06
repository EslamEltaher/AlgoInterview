////https://www.hackerrank.com/challenges/fraudulent-activity-notifications/problem

//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//namespace Algos_YakshTefla7._2021
//{

//    class Result
//    {

//        /*
//         * Complete the 'activityNotifications' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER_ARRAY expenditure
//         *  2. INTEGER d
//         */

//        public static int activityNotificationsPlus(List<int> expenditure, int d)
//        {
//            int[] nums = new int[201];
//            bool even = d % 2 == 0;

//            for (int i = 0; i < d; i++)
//            {
//                nums[expenditure[i]]++;
//            }

//            int notifications = 0;

//            for (int i = d; i < expenditure.Count; i++)
//            {
//                int count = d / 2;
//                int preMid = 0;
//                int mid = 0;

//                for (int j = 0; j <= 200; j++)
//                {
//                    if (nums[j] > 0)
//                    {

//                        if (count == 1 || (count > 1 && count - nums[j] < 1))
//                        {
//                            preMid = j;
//                        }

//                        if (count == 0 || (count > 0 && count - nums[j] < 0))
//                        {
//                            //if (count > 0)
//                                //midIndex = count - 1;
//                            mid = j;
//                        }
//                        count -= nums[j];
//                    }

//                    if (count < 0)
//                        break;
//                }

//                float median = even ? (float)(mid + preMid) / (float)2 : mid;

//                if ((float)expenditure[i] >= (float)2 * median)
//                    notifications++;

//                nums[expenditure[i - d]]--; //remove first
//                nums[expenditure[i]]++;     //add last
//            }


//            return notifications;

//        }
//        public static int activityNotifications(List<int> expenditure, int d)
//        {
//            LinkedList<int> list = new LinkedList<int>();
//            bool even = d % 2 == 0;

//            for (int i = 0; i < d; i++)
//            {
//                insertSorted(list, expenditure[i]);
//            }

//            LinkedListNode<int> midNode = list.First;
//            LinkedListNode<int> preMidNode = null;

//            for (int i = 0; i < d / 2; i++)
//            {
//                midNode = midNode.Next;
//            }

//            if (even)
//            {
//                preMidNode = midNode.Previous;
//            }

//            int notifications = 0;

//            for (int i = d; i < expenditure.Count; i++)
//            {
//                float median = even ? (float)(midNode.Value + preMidNode.Value) / (float)2 : midNode.Value;

//                if ((float)expenditure[i] >= (float)2 * median)
//                    notifications++;

//                //1 2 3 4 5
//                //1 2 3 3 5 (add before, remove after)  needs to go previous;
//                //1 3 4 5 6 (add after, remove before)  needs to go next
//                //1 1 3 4 5 (add before, remove before) no change
//                //1 2 3 5 6 (add after, remove after)   no change
//                //1 2 4 5 7 (remove self, add after)    needs to go next
//                //1 2 3 4 5 (remove self, add before)    needs to go before the (current after)
//                if (expenditure[i] <= midNode.Value && expenditure[i - d] > midNode.Value)
//                {
//                    midNode = midNode.Previous;
//                }
//                else if (expenditure[i] > midNode.Value && expenditure[i - d] <= midNode.Value)
//                {
//                    midNode = midNode.Next;
//                }
//                else if (expenditure[i] > midNode.Value && expenditure[i - d] == midNode.Value)
//                {
//                    midNode = midNode.Next;
//                }

//                var nextToMidNode = midNode.Next;

//                list.Remove(expenditure[i - d]);
//                insertSorted(list, expenditure[i]);

//                if (expenditure[i] <= midNode.Value && expenditure[i - d] == midNode.Value)
//                {
//                    midNode = nextToMidNode.Previous;
//                }

//                if (even)
//                    preMidNode = midNode.Previous;
//            }


//            return notifications;
//        }

//        public static LinkedListNode<int> insertSorted(LinkedList<int> list, int number)
//        {
//            if (list.First == null)
//                return list.AddFirst(number);

//            var node = list.First;

//            while (node != null && node.Value < number)
//            {
//                node = node.Next;
//            }

//            if (node != null)
//                return list.AddBefore(node, number);

//            return list.AddLast(number);
//        }
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(firstMultipleInput[0]);

//            int d = Convert.ToInt32(firstMultipleInput[1]);

//            List<int> expenditure = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(expenditureTemp => Convert.ToInt32(expenditureTemp)).ToList();

//            int result = Result.activityNotificationsPlus(expenditure, d);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
