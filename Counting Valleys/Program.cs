namespace Counting_Valleys
{

    /*key points
     * used flag "wasUnderSea" to check the status of last iteration
     * if it was true and current iteration is above or at sea level that counts as a valley
     * thats is
     * NOTE: I did not use the parameter 'int steps' as I didnt need too!
     */

    class Result
    {
        public static int countingValleys(int steps, string path)
        {
            char[] actions = [.. path]; //spreading the string which is an array of chars to explicit char[]
            const int seaLevel = 0;
            int altitude = 0;
            int valleys = 0;
            bool wasUnderSea = false;

            for (int i = 0; i < actions.Length; i++)
            {
                if (actions[i] == 'U')
                    altitude++;
                else if (actions[i] == 'D')
                    altitude--;

                if (altitude < seaLevel)
                    wasUnderSea = true;

                if (wasUnderSea && altitude == seaLevel)
                {
                    wasUnderSea = false;
                    valleys++;
                }
                Console.WriteLine(i + ": current altitude: " + altitude + " wasUnderSea: " + wasUnderSea + " valleys: " + valleys);
            }
            return valleys;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string _string = "UDDDUDUU";

            Console.WriteLine(Result.countingValleys(0, _string));

        }
    }
}
