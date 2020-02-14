////39 http://codeforces.com/problemset/problem/731/a

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
//            string word = Console.ReadLine();
//            Console.WriteLine(NightAtTheMuseum(word));
//        }

//        static int NightAtTheMuseum(string word)
//        {
//            int count = 0;
//            //char prev = 'a';
//            int prev = 0;

//            char[] chars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
//                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

//            for (int i = 0; i < word.Length; i++)
//            {
//                int indexOfChar = 0;
//                for (int j = 0; j < chars.Length; j++)
//                {
//                    if (chars[j] == word[i])
//                    {
//                        indexOfChar = j;
//                        break;
//                    }
//                }
//                count += Math.Min(Math.Min(Math.Abs(indexOfChar - prev), Math.Abs(chars.Length + indexOfChar - prev)), Math.Abs(chars.Length + prev - indexOfChar));
//                prev = indexOfChar;
//            }

//            return count;
//        }
//    }
//}