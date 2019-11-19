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
//        ableToAttack = 2 * (n - 1);

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

//        int canAttakTopLeft = limitUp < limitLeft ? limitUp : limitLeft;
//        int canAttackTopRight = limitUp < limitRight ? limitUp : limitRight;
//        int canAttackDownLeft = limitDown < limitLeft ? limitDown : limitLeft;
//        int canAttackDownRight = limitDown < limitRight ? limitDown : limitRight;

//        ableToAttack += canAttakTopLeft;
//        ableToAttack += canAttackTopRight;
//        ableToAttack += canAttackDownLeft;
//        ableToAttack += canAttackDownRight;

//        int blockedRight = 0;
//        int blockedLeft = 0;
//        int blockedUp = 0;
//        int blockedDown = 0;

//        int blockedTopLeft = 0;
//        int blockedTopRight = 0;
//        int blockedDownLeft = 0;
//        int blockedDownRight = 0;

//        for (int i = 0; i < k; i++)
//        {
//            int[] obstacle = obstacles[i];


//            int diffHorizontal = obstacle[1] - c_q;
//            int diffVertical = obstacle[0] - r_q;

//            //Horizontal (Right & Left)
//            if (obstacle[0] == r_q)
//            {
//                //int diffHorizontal = obstacle[1] - c_q;


//                //right
//                if (diffHorizontal > 0 && diffHorizontal > blockedRight)
//                    blockedRight = diffHorizontal;

//                //left
//                if (diffHorizontal < 0 && -diffHorizontal > blockedLeft)
//                    blockedLeft = -diffHorizontal;
//            }

//            //Vertical (Top & Down)
//            if (obstacle[1] == c_q)
//            {
//                //int diffVertical = obstacle[0] - r_q;

//                //Top
//                if (diffVertical > 0 && diffVertical > blockedUp)
//                    blockedUp = diffVertical;

//                //Down
//                if (diffVertical < 0 && -diffVertical > blockedDown)
//                    blockedDown = -diffVertical;
//            }

//            bool isDiagonal = diffHorizontal == diffVertical || -diffHorizontal == diffVertical;
//            if (isDiagonal)
//            {
//                //Right
//                if(diffHorizontal > 0)
//                {
//                    //top
//                    if(diffVertical > 0 && diffVertical > blockedTopRight)
//                    {
//                        blockedTopRight = diffVertical;
//                    }

//                    //Down
//                    if(diffVertical < 0 && -diffVertical > blockedDownRight)
//                    {
//                        blockedDownRight = -diffVertical;
//                    }
//                }
                
//                //Left
//                else
//                {
//                    //top
//                    if (diffVertical > 0 && diffVertical > blockedTopLeft)
//                    {
//                        blockedTopLeft = diffVertical;
//                    }

//                    //Down
//                    if (diffVertical < 0 && -diffVertical > blockedDownLeft)
//                    {
//                        blockedDownLeft = -diffVertical;
//                    }
//                }
//            }
//        }


//        return ableToAttack;
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
