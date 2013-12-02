using System;
using System.Text;

namespace _05.FallDownSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];

            // Input
            for (int row = 0; row < 8; row++)
            {
                int num = int.Parse(Console.ReadLine());
                string numToString = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = int.Parse(numToString[col].ToString());
                }
            }

            // Solution
            for (int col = 0; col < 8; col++)
            {
                int[] temp = new int[8];
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        temp[row] = 1;
                    }
                }

                Array.Sort(temp);

                for (int i = 0; i < 8; i++)
                {
                    matrix[7 - i, col] = temp[7 - i];
                }
            }

            //for (int row = 0; row < 8; row++)
            //{
            //    for (int col = 0; col < 8; col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // Output
            for (int row = 0; row < 8; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < 8; col++)
                {
                    sb.Append(matrix[row, col]);
                }

                int num = Convert.ToInt32(sb.ToString(), 2);
                Console.WriteLine(num);
            }
        }
    }
}