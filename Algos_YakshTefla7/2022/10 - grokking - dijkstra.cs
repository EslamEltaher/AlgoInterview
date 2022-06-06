//using System.Collections.Generic;

//namespace program
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var graph = new Dictionary<string, Dictionary<string, int>>();

//            graph["start"] = new Dictionary<string, int>();
//            graph["start"]["A"] = 6;
//            graph["start"]["B"] = 2;

//            graph["A"] = new Dictionary<string, int>();
//            graph["A"]["fin"] = 1;

//            graph["B"] = new Dictionary<string, int>();
//            graph["B"]["A"] = 3;
//            graph["B"]["fin"] = 5;

//            graph["fin"] = new Dictionary<string, int>();

//            #region Excercise B

//            //graph = new Dictionary<string, Dictionary<string, int>>();

//            //graph["start"] = new Dictionary<string, int>();
//            //graph["start"]["A"] = 10;

//            //graph["A"] = new Dictionary<string, int>();
//            //graph["A"]["B"] = 20;

//            //graph["B"] = new Dictionary<string, int>();
//            //graph["B"]["C"] = 1;
//            //graph["B"]["fin"] = 30;

//            //graph["C"] = new Dictionary<string, int>();
//            //graph["C"]["A"] = 1;


//            //graph["fin"] = new Dictionary<string, int>();
//            #endregion


//            var path = AL.Dijkstra.findPath(graph);

//            if (path.Item1 == int.MaxValue)
//            {
//                System.Console.WriteLine("Max Value");
//            }
//            else
//            {
//                System.Console.WriteLine($"Cost: {path.Item1}");
//                var item = path.Item2.First;

//                while (item != null)
//                {
//                    System.Console.Write(item.Value + " >>> ");
//                    item = item.Next;
//                }
//            }
//        }
//    }
//}

//namespace AL
//{
//    public class Dijkstra
//    {
//        public static (int, LinkedList<string>) findPath(Dictionary<string, Dictionary<string, int>> graph)
//        {
//            var result = (int.MaxValue, new LinkedList<string>());

//            var costs = new Dictionary<string, int>();
//            var parents = new Dictionary<string, string>();

//            var checkedItem = new HashSet<string>();

//            //populating costs and parents hash tables
//            foreach (var item in graph.Keys)
//            {
//                if (item != "start")
//                {
//                    costs[item] = graph["start"].ContainsKey(item) ? graph["start"][item] : int.MaxValue;
//                    parents[item] = graph["start"].ContainsKey(item) ? "start" : null;
//                }
//            }

//            //checking each item
//            while (checkedItem.Count < costs.Count)
//            {
//                string minCostNode = null;

//                foreach (var item in costs.Keys)
//                {
//                    if (!checkedItem.Contains(item)
//                        && (minCostNode == null || costs[item] < costs[minCostNode]))
//                    {
//                        minCostNode = item;
//                    }
//                }

//                if (!string.IsNullOrEmpty(minCostNode))
//                {
//                    foreach (var item in graph[minCostNode])
//                    {
//                        var new_cost = costs[minCostNode] + item.Value;

//                        if (new_cost < costs[item.Key])
//                        {
//                            costs[item.Key] = new_cost;
//                            parents[item.Key] = minCostNode;
//                        }
//                    }

//                    checkedItem.Add(minCostNode);
//                }
//            }

//            //populating result list
//            if (costs["fin"] != int.MaxValue)
//            {
//                result.Item1 = costs["fin"];

//                var item = "fin";

//                while (item != "start")
//                {
//                    result.Item2.AddFirst(item);
//                    item = parents[item];
//                }
//            }

//            return result;
//        }
//    }
//}