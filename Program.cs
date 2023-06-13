namespace Practise_2D_Array
{
    internal class Program
    {

        static void calSum()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    sum = sum + array[row, col];
                }
            }

            Console.WriteLine("The sum of all elements in the array is: " + sum);
        }

            static void Main(string[] args)
             {
                calSum();
            }
    }
}