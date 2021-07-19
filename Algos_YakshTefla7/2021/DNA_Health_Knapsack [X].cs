////https://www.hackerrank.com/challenges/determining-dna-health/problem

//using System.Collections.Generic;
//using System.Linq;
//using System;


//namespace Algos_YakshTefla7._2021
//{
//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<string> genes = Console.ReadLine().TrimEnd().Split(' ').ToList();

//            List<int> health = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(healthTemp => Convert.ToInt32(healthTemp)).ToList();

//            int s = Convert.ToInt32(Console.ReadLine().Trim());

//            int min = Int32.MaxValue;
//            int max = Int32.MinValue;


//            for (int sItr = 0; sItr < s; sItr++)
//            {
//                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//                int first = Convert.ToInt32(firstMultipleInput[0]);

//                int last = Convert.ToInt32(firstMultipleInput[1]);

//                string d = firstMultipleInput[2];

//                //CalculateGenesWithStrand
//                int val = 0;

//                var tree = treePopulate(genes, health, first, last);

//                for(int i = 0; i < d.Length; i++)
//                {
//                    var letter = d[i];

//                    var child = tree.Root.Children.FirstOrDefault(node => node.C == d[i]);
//                    if (child != null)
//                        child.current++;

//                    tree.Root.Children.Where(node => node.current > 0).ToList().ForEach(node => {
//                        node.Children.ForEach(
//                            )
//                    });
//                }
//                //for (int current = first; current <= last; current++)
//                //{
//                //    string currentGene = genes[current];

//                //    int times = occurances(d, currentGene);

//                //    val += times * health[current];
//                //}
//                if (val < min) min = val;
//                if (val > max) max = val;
//            }

//            Console.WriteLine($"{min} {max}");
//        }

//        private static int knapsackOccurances(string d, string gene)
//        {
//            //d is longer than gene
//            //gene must fully exist in d

//            int count = 0;

//            int[,] knapsack = new int[d.Length, gene.Length];

//            for (int i = 0; i < d.Length; i++)
//            {
//                for (int j = 0; j < gene.Length; j++)
//                {
//                    if (d[i] != gene[j])
//                    {
//                        knapsack[i, j] = 0;
//                    }
//                    else if (d[i] == gene[j] && i != 0 && j != 0)
//                    {
//                        knapsack[i, j] = knapsack[i - 1, j - 1] + 1;
//                    }
//                    else
//                    {
//                        knapsack[i, j] = 1;
//                    }

//                    //gene must fully exist in d
//                    if (knapsack[i, j] == gene.Length)
//                    {
//                        count++;
//                    }
//                }
//            }

//            return count;
//        }
//        private static int occurances(string d, string gene)
//        {
//            int count = 0;
//            Dictionary<int, bool> beggings = new Dictionary<int, bool>();
//            for (int i = 0; i < d.Length; i++)
//            {
//                if (d[i] == gene[0])
//                    beggings.Add(i, true);

//                foreach (int b in beggings.Keys.ToList())
//                {
//                    if (beggings[b])
//                    {
//                        if (gene[i - b] != d[i])
//                            //beggings[b] = false;
//                            beggings.Remove(b);

//                        else if ((i - b) == (gene.Length - 1))
//                        {
//                            count++;
//                            //beggings[b] = false;
//                            beggings.Remove(b);
//                        }
//                    }
//                }
//            }

//            return count;
//        }

//        private static Tree treePopulate(List<string> strings, List<int> values, int first, int last)
//        {
//            Tree tree = new Tree();

//            for (int i = first; i <= last; first++)
//            {
//                string s = strings[i];
//                var node = addCharToNode(tree.Root, s[0], 0);
//                if (s.Length > 1)
//                {
//                    for (int j = 1; j < s.Length; j++)
//                        addCharToNode(node, s[j], 0);
//                }
//                node.Value = values[i];
//            }
            
//            return tree;
//        }

//        private static Node addCharToNode(Node node, char c, int val)
//        {
//            var child = node.Children.FirstOrDefault(cc => cc.C == c);
//            if (child == null)
//            {
//                child = new Node(c, val);
//                node.Children.Add(child);
//            }
//            return child;
//        }

//        private static Node traverse(Node parent)
//        {
//            if(parent.current > 0)
//            {
//                var workingChildren = parent.Children.Where(n => n.current > 0).ToList()
//                if(workingChildren.Count == 0)
//                {
//                    return parent;
//                } 
//                else
//                {
//                    return 
//                }
//            }
//        }
//    }

//    class Tree
//    {
//        public Node Root { get; set; }
//    }

//    class Node
//    {
//        public char C { get; set; }
//        public int Value { get; set; }
//        public int current { get; set; }
//        public List<Node> Children { get; set; }
//        public Node(char c, int val)
//        {
//            C = c;
//            Value = val;
//            current = 0;
//            Children = new List<Node>();
//        }

//        public void IncreaseCurrent()
//        {

//        }
//    }
//}
