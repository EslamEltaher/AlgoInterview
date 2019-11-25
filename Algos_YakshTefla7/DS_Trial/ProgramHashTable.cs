//using Algos_YakshTefla7.DS_Trial;
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
//            // The code provided will print ‘Hello World’ to the console.
//            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
//            Console.WriteLine("Hello World!");
//            Console.ReadKey();

//            HashTable<string, string> myHashTable = new HashTable<string, string>();

//            int mil = 1000000 * 10;

//            for(int i = 0; i < mil; i ++)
//            {
//                if (i % 1000000 == 0)
//                    Console.WriteLine(i / 1000000);
//                myHashTable.Insert("Key" + i.ToString(), "Value" + i.ToString());
//            }

//            myHashTable.Insert("Key2", "Value2");
//            myHashTable.Insert("Key3", "Value3");

//            for (int i = 0; i < mil; i++)
//                Console.WriteLine(myHashTable.Get("Key" + i.ToString()));

//            Console.WriteLine(myHashTable.Get("Key1"));
//            Console.WriteLine(myHashTable.Get("Key2"));
//            Console.WriteLine(myHashTable.Get("Key3"));

//            Console.ReadLine();

//            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
//        }
//    }
//}
