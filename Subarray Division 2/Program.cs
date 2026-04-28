namespace Subarray_Division_2
{
    static class Result
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int sumOfSqauers = 0;
            int noOfWays = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                sumOfSqauers = s[i];
                for (int j = i + 1; j < i + m; j++)
                {
                    sumOfSqauers += s[j];
                }
                if(sumOfSqauers == d)
                    noOfWays++;
            }
            return noOfWays;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result.birthday([4], 4, 1));
        }
    }
}
