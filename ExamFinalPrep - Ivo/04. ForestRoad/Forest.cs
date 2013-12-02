using System;

class Forest
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[2 * N - 1, N];
        
        // solution
        int currentRow = 0;
        int currentCol = 0;

        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;

            if (currentRow < N)
            {
                currentCol++;
            }
            else
            {
                currentCol--;
            }

            if (currentRow == N * 2 - 1)
            {
                break;
            }
        }

        // printing
        for (int row = 0; row < 2 * N - 1; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }

            Console.WriteLine();
        }
    }
}
