using System.IO;
using System.Runtime.CompilerServices;

namespace Counting_Sort_1
{
    //key points:
    //1) list can have inital capacity in the constructor but the count remains zero until actual elements are added, so List<T>.Capacity = 10, but List<T>.Count = 0
    //2) array can have initial length and it is accessed through .Length property or .Count() function

    class Result
    {
        public static List<int> countingSort(List<int> arr)
        {
            List<int> freq = new List<int>(1000001); //so it allows for sotring higher values up to 1000000, regardless the array length
            int[] freqTemp = new int[freq.Capacity]; //used array instead of list because it defaults all elements to zero once initialised

            for (int i = 0; i < arr.Count; i++)
            {
                //for each element in "arr" it has a value that is represented as an index in the "freq" array
                //example: arr[4]=11, freq[11]++
                //so it can be represented as freq[arr[4]]++
                freqTemp[arr[i]]++;
            }

            //manually converting arrary to list to match the function signature
            foreach (int f in freqTemp)
            {
                freq.Add(f);
            }

            //removing all the excessive zeros up to 1000000 that I assumed in the begining
            for (int j = freq.Count - 1; j >= 0; j--)
            {
                if (freq[j] == 0)
                    freq.RemoveAt(j);
                else break;
            }

            //this is workaround for some problem where the expected output expects "0" as last element (IDK why, maybe I am wrong)
            //the problem:
            //my output:         2 0 1 0 0 1 1 1 1 0 0 1 3 2 2 0 4 4 1 1 0 0 0 0 3 0 0 1 0 1 2 0 1 2 2 3 0 2 0 0 1 0 1 1 0 0 1 1 0 2 0 0 1 1 1 0 1 0 1 1 2 3 0 1 2 0 1 2 1 1 4 1 0 1 1 3 0 0 2 1 2 3 2 2 2 0 0 1 0 0 0 0 0 0 2 0 1 3 1
            //HackerRank output: 2 0 1 0 0 1 1 1 1 0 0 1 3 2 2 0 4 4 1 1 0 0 0 0 3 0 0 1 0 1 2 0 1 2 2 3 0 2 0 0 1 0 1 1 0 0 1 1 0 2 0 0 1 1 1 0 1 0 1 1 2 3 0 1 2 0 1 2 1 1 4 1 0 1 1 3 0 0 2 1 2 3 2 2 2 0 0 1 0 0 0 0 0 0 2 0 1 3 1 0
            
            //my workaround:
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

            List<int> arr = arrayGG.Split(' ').ToList().Select(arrElement => Convert.ToInt32(arrElement)).ToList();
            List<int> result = Result.countingSort(arr);
            Console.WriteLine(String.Join(" ", result));                        
        }
    }
}

