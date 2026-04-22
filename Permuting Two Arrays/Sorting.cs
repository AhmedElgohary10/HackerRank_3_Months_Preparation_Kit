using System;
using System.Collections.Generic;
using System.Text;

namespace Permuting_Two_Arrays
{
    public static class Sorting
    {
        // A = [2, 1, 3]

        public static List<int> MySort(this List<int> l)
        {
            int globalMin = l.MinNumber();


            for (int i = 1; i < l.Count; i++)
            {
                int localMin = l[i];
                if (l[i - 1] > l[i])
                {
                    l[i] = l[i - 1];
                    l[i - 1] = localMin;
                }
            }

            return l;
        }

        public static List<int> MySortV2(this List<int> l)
        {
            int length = l.Count;
            List<int> sortedList = new();

            while (sortedList.Count < length)
            {
                sortedList.Add(l.MinNumber());
                l.Remove(l.MinNumber());
            }

            return sortedList;
        }

        public static int MaxNumber(this List<int> l)
        {
            int max = 0;
            foreach (int i in l)
                if (i > max) max = i;
            return max;
        }
        public static int MinNumber(this List<int> l)
        {
            int min = l[0];
            foreach (int i in l)
                if (i < min) min = i;
            return min;
        }
    }
}
