////5 https://www.hackerrank.com/challenges/queens-attack-2/

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

//    // Complete the queensAttack function below.
//    static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
//    {
//        int ableToAttack = 0;

//        //adding up & down & left & right;
//        //the queen can attack as much rows and columns except the one she's at
//        //ableToAttack = 2 * (n - 1);

//        //computing diagonal
//        //limit up can affect topRight & TopLeft
//        //limit down can Affect DownRight & DownLeft
//        //limit Right can affect topRight & DownRight
//        //limit Left can affect TopLeft & DownLeft

//        int limitUp = n - r_q;
//        int limitDown = r_q - 1;
//        int limitLeft = c_q - 1;
//        int limitRight = n - c_q;

//        //int[] farestTopLeft = { };
//        //int[] farestTopRight = { };
//        //int[] farestDownLeft = { };
//        //int[] farestDownRight = { };

//        //deciding which direction in diagonals limits the other

//        int canAttackTopLeft = limitUp < limitLeft ? limitUp : limitLeft;
//        int canAttackTopRight = limitUp < limitRight ? limitUp : limitRight;
//        int canAttackDownLeft = limitDown < limitLeft ? limitDown : limitLeft;
//        int canAttackDownRight = limitDown < limitRight ? limitDown : limitRight;


//        for (int i = 0; i < k; i++)
//        {
//            int[] obstacle = obstacles[i];

//            int diffHorizontal = obstacle[1] - c_q;
//            int diffVertical = obstacle[0] - r_q;

//            int diffHorizontalAbs = diffHorizontal > 0 ? diffHorizontal : -diffHorizontal;
//            int diffVerticalAbs = diffVertical > 0 ? diffVertical : -diffVertical;

//            bool isRight = diffHorizontal > 0;
//            bool isTop = diffVertical > 0;

//            //Horizontal (Right & Left)
//            if (obstacle[0] == r_q)
//            {
//                //right
//                if (isRight)
//                    limitRight = min(limitRight, diffHorizontalAbs - 1);

//                //left
//                if (!isRight)
//                    limitLeft = min(limitLeft, diffHorizontalAbs - 1);
//            }

//            //Vertical (Top & Down)
//            if (obstacle[1] == c_q)
//            {
//                //Top
//                if (isTop)
//                    limitUp = min(limitUp, diffVerticalAbs - 1);

//                //Down
//                if (!isTop)
//                    limitDown = min(limitDown, diffVerticalAbs - 1);
//            }

//            //bool isDiagonal = diffHorizontal == diffVertical || -diffHorizontal == diffVertical;
//            if (diffHorizontalAbs == diffVerticalAbs)
//            {
//                //Right
//                if(isRight && isTop)
//                        canAttackTopRight = min(canAttackTopRight, diffVerticalAbs - 1);
//                if (isRight && !isTop)
//                    canAttackDownRight = min(canAttackDownRight, diffVerticalAbs - 1);


//                //Left
//                if (!isRight && isTop)
//                    canAttackTopLeft = min(canAttackTopLeft, diffVerticalAbs - 1);

//                if (!isRight && !isTop)
//                    canAttackDownLeft = min(canAttackDownLeft, diffVerticalAbs - 1);
//            }
//        }

//        ableToAttack += limitUp;
//        ableToAttack += limitDown;
//        ableToAttack += limitLeft;
//        ableToAttack += limitRight;

//        ableToAttack += canAttackTopLeft;
//        ableToAttack += canAttackTopRight;
//        ableToAttack += canAttackDownLeft;
//        ableToAttack += canAttackDownRight;

//        return ableToAttack;
//    }

//    static int min(int a, int b)
//    {
//        return a < b ? a : b;
//    }
//    static int max(int a, int b)
//    {
//        return a > b ? a : b;
//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nk = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nk[0]);

//        int k = Convert.ToInt32(nk[1]);

//        string[] r_qC_q = Console.ReadLine().Split(' ');

//        int r_q = Convert.ToInt32(r_qC_q[0]);

//        int c_q = Convert.ToInt32(r_qC_q[1]);

//        int[][] obstacles = new int[k][];

//        for (int i = 0; i < k; i++)
//        {
//            obstacles[i] = Array.ConvertAll(Console.ReadLine().Split(' '), obstaclesTemp => Convert.ToInt32(obstaclesTemp));
//        }

//        int result = queensAttack(n, k, r_q, c_q, obstacles);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
