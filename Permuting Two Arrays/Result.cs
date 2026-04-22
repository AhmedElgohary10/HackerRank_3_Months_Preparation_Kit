using System;
using System.Collections.Generic;
using System.Text;

namespace Permuting_Two_Arrays
{
    /*                  Sample Input
                        STDIN       Function
                        -----       --------
                        3 10        A[] and B[] size n = 3, k = 10
                        2 1 3       A = [2, 1, 3]
                        7 8 9       B = [7, 8, 9]
                        4 5         A[] and B[] size n = 4, k = 5
                        1 2 2 1     A = [1, 2, 2, 1]
                        3 3 3 4     B = [3, 3, 3, 4]

                        Sample Output                            
                        YES
                        NO
    */
    internal class Result
    {
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B.Sort();
            B.Reverse();

            for (int i = 0; i < A.Count; i++)
                if (A[i] + B[i] < k)
                    return "NO";
            
            return "YES";
        }
    }
}
