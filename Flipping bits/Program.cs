using System.ComponentModel;

namespace Flipping_bits
{




    //bit is the bulding unit of digital data (smallest unit) = 1 or 0
    //unsigned int means no (-) only zero and absolute values (0,1,2,3,4,---> infinity)
    //that leaves us with unsigned bit meaninig 0,1 only
    //long vs int datatype? deep search aside from long being bigger size than int

    internal class Program
    {
        class Result
        {
            //my thoughts 
                //step 1 convert decimal number to binary 32 bits
                //step 2 invert 0 to 1 and 1 to 0
                //step 3 conver the binary invert to deciaml

            //correct C# implementation
                //1) store the input (positive whole number from 0 to >2^32 which is the positive part on the "long" data type)
                //into unsinged 32 bit container (C# gives us uint data type and Convert.ToUInt32() function to convert long to it)
                //2) convert the number using binarywise operator ~ that also C# gives to us

            // key new points:
                //1- unsigned numeric types: uint ilong etc, int is 32 bit half positive and half negative, unit is 32 bits all positive
                //2- binarywise operators (&, |, ~, >>, <<)


            public static long flippingBits(long n)
            {
                uint gg = Convert.ToUInt32(n);
                return ~gg;
            }

        }


        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());
                long result = Result.flippingBits(n);
                Console.WriteLine(result);
            }

        }
    }
}
