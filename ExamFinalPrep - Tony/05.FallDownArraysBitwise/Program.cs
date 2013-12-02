using System;

namespace _05.FallDownArraysBitwise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Input
            int[] nums = new int[8];
            for (int i = 0; i < 8; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //for (int j = 0; j < 8; j++)
            //{
            //    string numToString = Convert.ToString(nums[j], 2).PadLeft(8, '0');
            //    Console.WriteLine(numToString);
            //}
            //Console.WriteLine();

            // Solution
            for (int i = 0; i < 7; i++)
            {
                for (int row = 7; row > 0; row--)
                {
                    for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                    {
                        if ((nums[row] >> bitPosition & 1) == 0 &&
                            (nums[row - 1] >> bitPosition & 1) == 1)
                        {
                            nums[row] |= (1 << bitPosition);
                            nums[row - 1] ^= (1 << bitPosition);
                        }
                    }
                }

                //for (int j = 0; j < 8; j++)
                //{
                //    string numToString = Convert.ToString(nums[j], 2).PadLeft(8, '0');
                //    Console.WriteLine(numToString);
                //}
                //Console.WriteLine();
            }

            // Output
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}