using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_06
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

           // Given a square matrix, calculate the absolute difference between the sums of its diagonals.
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ')
                    .ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);

        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int mainDiagonal = 0;
            int secondaryDiagonal = 0;


            for (int row = 0; row < arr.Count; row++)
            {
                mainDiagonal += arr[row][row];
                secondaryDiagonal += arr[row][arr.Count - row - 1];
            }

            return Math.Abs(mainDiagonal - secondaryDiagonal);
        }
    }
}
