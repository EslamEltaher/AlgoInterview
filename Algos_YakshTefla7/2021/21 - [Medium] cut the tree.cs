////https://www.hackerrank.com/challenges/cut-the-tree/problem

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
//         * Complete the 'cutTheTree' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER_ARRAY data
//         *  2. 2D_INTEGER_ARRAY edges
//         */

//        public static int cutTheTree(List<int> data, List<List<int>> edges)
//        {
//            Node[] nodes = new Node[data.Count + 1];


//            int sum = 0;
//            data.ForEach(x => sum += x);


//            diff = sum;
//            var root = new Node() { Value = data[0] };
//            nodes[1] = root;

//            Queue<List<int>> queue = new Queue<List<int>>(edges);

//            while(queue.Count > 0)
//            {
//                var pair = queue.Dequeue();

//                int x = pair[0];
//                int y = pair[1];

//                if (nodes[x] == null)
//                    nodes[x] = new Node() { Value = data[x - 1] };

//                if (nodes[y] == null)
//                    nodes[y] = new Node() { Value = data[y - 1] };


//                nodes[x].Children.Add(nodes[y]);
//                nodes[y].Children.Add(nodes[x]);
//                //if (x == 1)
//                //{
//                //    nodes[y].setParent(nodes[x]);
//                //}
//                //else if (y == 1)
//                //{
//                //    nodes[x].setParent(nodes[y]);
//                //}
//                //else
//                //{
//                //    if (nodes[x].Parent != null)
//                //        nodes[y].setParent(nodes[x]);
//                //    else if (nodes[y].Parent != null)
//                //        nodes[x].setParent(nodes[y]);
//                //    else
//                //        queue.Enqueue(pair);
//                //}
//            }


//            traverseSetParent(root);
//            traverse(root, sum);

//            return diff;
//        }

//        private static int diff;

//        public static int traverse(Node node, int sum)
//        {
//            int val = node.Value;
//            foreach (var child in node.Children)
//            {
//                int ch = traverse(child, sum);

//                int newDiff = Math.Abs(sum - 2 * ch);
//                if (newDiff < diff)
//                {
//                    diff = newDiff;
//                }
//                val += ch;
//            }

//            return val;
//        }
//        public static void traverseSetParent(Node parent)
//        {
//            foreach (var child in parent.Children)
//            {
//                child.Parent = parent;
//                child.Children.Remove(parent);
//                traverseSetParent(child);
//            }
//        }
//    }

//    class Tree
//    {
//        public Node Root { get; set; }
//    }

//    class Node
//    {
//        public int Value { get; set; }
//        public List<Node> Children { get; set; }
//        public Node Parent { get; set; }

//        public Node() : this(0)
//        {
//        }

//        public Node(int value)
//        {
//            Value = value;
//            Children = new List<Node>();
//        }

//        public void addChild(Node child)
//        {
//            if(!Children.Contains(child))
//                Children.Add(child);
//            child.Parent = this;
//        }

//        public void setParent(Node parent)
//        {
//            parent.addChild(this);
//        }
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> data = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(dataTemp => Convert.ToInt32(dataTemp)).ToList();

//            List<List<int>> edges = new List<List<int>>();

//            for (int i = 0; i < n - 1; i++)
//            {
//                edges.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(edgesTemp => Convert.ToInt32(edgesTemp)).ToList());
//            }

//            int result = Result.cutTheTree(data, edges);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }

//}
