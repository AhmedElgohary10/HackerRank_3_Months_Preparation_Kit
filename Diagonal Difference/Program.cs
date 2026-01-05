namespace Diagonal_Difference
{

    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int result;
            int mainDiagonal = 0;
            int secDiagonal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                mainDiagonal += arr[i][i];
            }

            for (int i = 0; i < arr.Count; i++)
            {
                secDiagonal += arr[i][arr[i].Count - 1 - i];
            }

            result = mainDiagonal - secDiagonal;
            if (result < 0)
                result = -result;

            return result;

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new() { 11, 2, 3 };
            List<int> l2 = new() { 5, 6, 4 };
            List<int> l3 = new() { 7, 2, 9 };

            List<List<int>> arr = new();
            arr.Add(l1);
            arr.Add(l2);
            arr.Add(l3);

            Console.WriteLine(Result.diagonalDifference(arr));


        }
    }
}
