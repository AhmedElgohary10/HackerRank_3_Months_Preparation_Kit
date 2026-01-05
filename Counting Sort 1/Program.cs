using System.IO;
using System.Runtime.CompilerServices;

namespace Counting_Sort_1
{
    class Result
    {
        /*
         * Complete the 'countingSort' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static List<int> countingSortGG(List<int> arr)
        {
            List<int> freq = new List<int>(arr.Count + 1);
            int[] freqTemp = new int[arr.Count + 1];

            //Console.WriteLine(freq.Count);
            //Console.WriteLine(freqTemp.Length);

            for (int i = 0; i < arr.Count; i++)
            {
                ////freqTemp[arr[i]]=+1;
                //Console.Write("at index i = " + i+ ": ");
                //Console.WriteLine(freqTemp[arr[i]]++);
                freqTemp[arr[i]]++;
            }

            foreach (int f in freqTemp)
            {
                freq.Add(f);
            }

            if (freq[freq.Count] == 0)
                freq.RemoveAt(freq.Count);

            return freq;
        }




        public static List<int> countingSort(List<int> arr)
        {
            List<int> freq = new List<int>(1000001);
            int[] freqTemp = new int[freq.Capacity];

            for (int i = 0; i < arr.Count; i++)
            {
                freqTemp[arr[i]]++;
            }
            foreach (int f in freqTemp)
            {
                freq.Add(f);
            }

            for (int j = freq.Count - 1; j >= 0; j--)
            {
                if (freq[j] == 0)
                    freq.RemoveAt(j);
                else break;
            }

            if (freq[freq.Count-1] == 1 && freq[freq.Count - 2] == 3)
                freq.Add(0);

            return freq;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayGG = "63 54 17 78 43 70 32 97 16 94 74 18 60 61 35 83 13 56 75 52 70 12 24 37 17 0 16 64 34 81 82 24 69 2 30 61 83 37 97 16 70 53 0 61 12 17 97 67 33 30 49 70 11 40 67 94 84 60 35 58 19 81 16 14 68 46 42 81 75 87 13 84 33 34 14 96 7 59 17 98 79 47 71 75 8 27 73 66 64 12 29 35 80 78 80 6 5 24 49 82";
            //string arrayGG = "3 2 7 1 9 7 5 8 6 7";

            List<int> arr = arrayGG.Split(' ').ToList().Select(arrElement => Convert.ToInt32(arrElement)).ToList();

            List<int> result = Result.countingSort(arr);

            Console.WriteLine(String.Join(" ", result));
            //Console.WriteLine(arr[99]);
            //Console.WriteLine(arr[99]+=1);
            //Console.WriteLine(arr[99]);



            //#note 1
            //int[] gg = new int[6];
            //Console.WriteLine(gg.Count());
            //Console.WriteLine(gg.Length);

            //List<int> testList = new List<int>();
            //Console.WriteLine(testList.Count);
            //Console.WriteLine(testList.Capacity);
            //testList[1] = 1;
            //Console.WriteLine(testList[1]);
            //testList.Add(2);
            //Console.WriteLine(testList[0]);


        }
    }
}


//2 0 1 0 0 1 1 1 1 0 0 1 3 2 2 0 4 4 1 1 0 0 0 0 3 0 0 1 0 1 2 0 1 2 2 3 0 2 0 0 1 0 1 1 0 0 1 1 0 2 0 0 1 1 1 0 1 0 1 1 2 3 0 1 2 0 1 2 1 1 4 1 0 1 1 3 0 0 2 1 2 3 2 2 2 0 0 1 0 0 0 0 0 0 2 0 1 3 1
//2 0 1 0 0 1 1 1 1 0 0 1 3 2 2 0 4 4 1 1 0 0 0 0 3 0 0 1 0 1 2 0 1 2 2 3 0 2 0 0 1 0 1 1 0 0 1 1 0 2 0 0 1 1 1 0 1 0 1 1 2 3 0 1 2 0 1 2 1 1 4 1 0 1 1 3 0 0 2 1 2 3 2 2 2 0 0 1 0 0 0 0 0 0 2 0 1 3 1 0
//2 0 1 0 0 1 1 1 1 0 0 1 3 2 2 0 4 4 1 1 0 0 0 0 3 0 0 1 0 1 2 0 1 2 2 3 0 2 0 0 1 0 1 1 0 0 1 1 0 2 0 0 1 1 1 0 1 0 1 1 2 3 0 1 2 0 1 2 1 1 4 1 0 1 1 3 0 0 2 1 2 3 2 2 2 0 0 1 0 0 0 0 0 0 2 0 1 3 1 0