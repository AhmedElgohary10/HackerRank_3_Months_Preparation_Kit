namespace Permuting_Two_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Result.twoArrays(5, [1, 2, 2, 1], [3, 3, 3, 4]));
            List<int> gg = [2, 1, 3,0,9,0,1];
            //gg.MySort();

            var bb = gg.MySortV2();

            foreach (int x in bb)
                Console.WriteLine(x);
        }
    }
}
