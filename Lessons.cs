using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_Massive
{
    internal class Lessons
    {
        static void Work(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] array3 = new int[6];

            array3[0] = 1;
            array3[1] = 2;
            array3[2] = 3;
            array3[3] = 4;

            Array.Sort(array3);
            Array.Reverse(array3);
            int result = Array.IndexOf(array3, 1);
            int result_2 = Array.LastIndexOf(array2, 1);
            Array.Clear(array3, 1, 2);
            Array.ConstrainedCopy(array3, 2, array2, 6, 5);

            int[,] matrix = new int[3, 4];
            matrix[1, 2] = 3;
            Random ran = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = ran.Next(10);
                    matrix[1, 2] = 3;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            string[,] table = new string[,] {
                                        {"00", "0.1", "0.2", "22"},
                                        {"00", "0.1", "0.2", "22"},
                                        {"00", "0.1", "0.2", "22"}
                                            };
                          
            Console.WriteLine($"table.Rank = {table}");
            Console.WriteLine($"table.Rank = {table.GetLength(0)}");
            Console.WriteLine($"table.Rank = {table.GetLength(1)}");

            int[] alfa = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] beta = new int[3, 3];

            int counter = 0;

            for (int iter_0 = 0; iter_0 < beta.GetLength(0); iter_0++)
            {
                for (int iter_1 = 0;iter_1 < beta.GetLength(1);iter_1++)
                {
                    beta[iter_0, iter_1] = alfa[counter++];
                    Console.Write($"{beta[iter_0, iter_1]} ");
               
               }
                Console.WriteLine();
            }

            int[,,] matrix3D = new int[3, 4, 5];

            Console.WriteLine($"table.Rank = {matrix3D}");
            Console.WriteLine($"table.Rank = {matrix3D.GetLength(0)}");
            Console.WriteLine($"table.Rank = {matrix3D.GetLength(1)}");
            Console.WriteLine($"table.Rank = {matrix3D.GetLength(2)}");

            int[][] arrayArray = new int[3][];
            arrayArray[0] = new int[3];
            arrayArray[0][0] = 1;
            arrayArray[0][1] = 2;
            arrayArray[0][2] = 3;

            arrayArray[1] = new int[3];
            arrayArray[1][0] = 4;
            arrayArray[2][1] = 5;
            arrayArray[2][2] = 6;

            arrayArray[2] = new int[2];
            arrayArray[2][0] = 7;
            arrayArray[2][1] = 8;



        }
    }
}
