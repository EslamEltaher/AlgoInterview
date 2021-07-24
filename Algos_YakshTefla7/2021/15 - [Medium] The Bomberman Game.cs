//https://www.hackerrank.com/challenges/bomber-man/problem
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Algos_YakshTefla7._2021
{

    class Result
    {

        /*
         * Complete the 'bomberMan' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. STRING_ARRAY grid
         */

        public static List<string> bomberMan(int n, List<string> grid)
        {
            int r = grid.Count;
            int c = grid[0].Length;

            //init
            //1. nothing
            //2. plants all
            //3. stops

            //0.     ..0..
            //1.     ..0..
            //2.     00000
            //3.     0...0
            //4.     00000
            //5.     ..0..
            //6.     00000
            //7.     0...0
            //8.     00000
            //9.     ..0..

            if (n == 0 || n == 1)
                return grid;

            if (n % 2 == 0)
            {
                string all = "";

                for (int i = 0; i < c; i++)
                    all += "0";

                grid = grid.Select(row => all).ToList();
            }

            if(true)
            {
                List<string> newGrid = new List<string>();
                for(int i = 0; i < grid.Count; i++)
                {
                    string res = "";
                    for (int j = 0; j < c; j++)
                    {
                        if(
                            (grid[i][j] == 'O')
                            || (i > 0 && grid[i-1][j] == 'O') 
                            || (i < r - 1 && grid[i + 1][j] == 'O')
                            || (j > 0 && grid[i][j - 1] == 'O')
                            || (j < c - 1 && grid[i][j + 1] == 'O')
                            )
                        {
                            res += ".";
                        }
                        else
                        {
                            res += "O";
                        }
                    }

                    newGrid.Add(res);
                }
                grid = newGrid;
            }

            if(n % 4 == 1)
            {
                List<string> newGrid = new List<string>();
                for (int i = 0; i < grid.Count; i++)
                {
                    string res = "";
                    for (int j = 0; j < c; j++)
                    {
                        if (
                            (grid[i][j] == 'O')
                            || (i > 0 && grid[i - 1][j] == 'O')
                            || (i < r - 1 && grid[i + 1][j] == 'O')
                            || (j > 0 && grid[i][j - 1] == 'O')
                            || (j < c - 1 && grid[i][j + 1] == 'O')
                            )
                        {
                            res += ".";
                        }
                        else
                        {
                            res += "O";
                        }
                    }

                    newGrid.Add(res);
                }
                grid = newGrid;
            }

            return grid;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int r = Convert.ToInt32(firstMultipleInput[0]);

            int c = Convert.ToInt32(firstMultipleInput[1]);

            int n = Convert.ToInt32(firstMultipleInput[2]);

            List<string> grid = new List<string>();

            for (int i = 0; i < r; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            List<string> result = Result.bomberMan(n, grid);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
