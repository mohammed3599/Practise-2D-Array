using System;

namespace Practise_2D_Array
{
    internal class Program
    {

        static void calSum()
        {
            int[,] sumArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;

            for (int row = 0; row < sumArray.GetLength(0); row++)
            {
                for (int col = 0; col < sumArray.GetLength(1); col++)
                {
                    sum = sum + sumArray[row, col];
                }
            }

            Console.WriteLine("The sum of all elements in the array is: " + sum);
            Console.WriteLine();
        }

        static void calAvg()
        {
            int[,] averageArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int row = averageArray.GetLength(0);
            int column = averageArray.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                int sum = 0;
                for (int j = 0; j < column; j++)
                {
                    sum += averageArray[i, j];
                }

                double average = (double)sum / column;
                Console.WriteLine("Average of Row {0}: {1}", i + 1, average);
            }
            Console.WriteLine();
        }

        

        static void search()
        {
            int[,] searchArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.Write("Please Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int rows = searchArray.GetLength(0);
            int columns = searchArray.GetLength(1);

            int searchRow = -1;
            int searchCol = -1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (searchArray[i, j] == search)
                    {
                        searchRow = i;
                        searchCol = j;
                        break;
                    }
                }
            }

            if (searchRow != -1 && searchCol != -1)
            {
                Console.WriteLine("The search number found at position ({0}, {1}).", searchRow, searchCol);
            }
            else
            {
                Console.WriteLine("The search number not found in the array.");
            }
        }
            static void Main(string[] args)
             {
                calSum();
                calAvg();
                search();
            }
    }
}