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

//class Solution
//{

//    class DoublyLinkedListNode
//    {
//        public int data;
//        public DoublyLinkedListNode next;
//        public DoublyLinkedListNode prev;

//        public DoublyLinkedListNode(int nodeData)
//        {
//            this.data = nodeData;
//            this.next = null;
//            this.prev = null;
//        }
//    }

//    class DoublyLinkedList
//    {
//        public DoublyLinkedListNode head;
//        public DoublyLinkedListNode tail;

//        public DoublyLinkedList()
//        {
//            this.head = null;
//            this.tail = null;
//        }

//        public void InsertNode(int nodeData)
//        {
//            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

//            if (this.head == null)
//            {
//                this.head = node;
//            }
//            else
//            {
//                this.tail.next = node;
//                node.prev = this.tail;
//            }

//            this.tail = node;
//        }
//    }

//    static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
//    {
//        while (node != null)
//        {
//            textWriter.Write(node.data);

//            node = node.next;

//            if (node != null)
//            {
//                textWriter.Write(sep);
//            }
//        }
//    }

//    // Complete the sortedInsert function below.

//    /*
//     * For your reference:
//     *
//     * DoublyLinkedListNode {
//     *     int data;
//     *     DoublyLinkedListNode next;
//     *     DoublyLinkedListNode prev;
//     * }
//     *
//     */
//    static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data)
//    {
//        //first Node
//        var node = new DoublyLinkedListNode(data);

//        if (data < head.data)
//        {
//            head.prev = node;
//            node.next = head;
//            return node;
//        }

//        do
//        {
//            if(data > head.data && head.next == null)
//            {
//                node.prev = head;
//                head.next = node;
//            }
//            if(data < head.data)
//            {
//                node.prev = head.prev;
//                node.next = head;
//                head.prev = node;
//            }
//            head = head.next;
//        }
//        while (head.next != null);
        

//        return node;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int t = Convert.ToInt32(Console.ReadLine());

//        for (int tItr = 0; tItr < t; tItr++)
//        {
//            DoublyLinkedList llist = new DoublyLinkedList();

//            int llistCount = Convert.ToInt32(Console.ReadLine());

//            for (int i = 0; i < llistCount; i++)
//            {
//                int llistItem = Convert.ToInt32(Console.ReadLine());
//                llist.InsertNode(llistItem);
//            }

//            int data = Convert.ToInt32(Console.ReadLine());

//            DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);

//            PrintDoublyLinkedList(llist1, " ", textWriter);
//            textWriter.WriteLine();
//        }

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
