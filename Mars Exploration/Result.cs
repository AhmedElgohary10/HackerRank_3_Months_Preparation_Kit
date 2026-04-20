namespace Mars_Exploration
{
    internal class Result
    {

        //     0123456789
        // s = SOSSOSSOSSOSSOSSOSSOSSOS
        // s = SOSSPSSQSSORSOSSPSSQSSOR
        //S indexes: 0.2.3.5.6.7.8.9
        //O indexes: 1.4.7.10
        public static int marsExploration(string s)
        {
            if (s.Length == 0) return 0;
            int counter = 0;

            int oIndex = 1, sIndex = 0;
            const int oIncremint = 3;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == oIndex)
                {
                    if (s[i].ToString() != "O")
                        counter++;
                    oIndex += oIncremint;
                }
                else if (s[i].ToString() != "S")
                    counter++;

                //for (int i = 0; i < s.Length; i++)            
                //{
                //    switch (i)
                //    {
                //        case oIndex: ----------------> case oIndex => compiler error because case value supposed to be literal or const int
                //            break;                     so the compiler can create the "its index on Jump Table" before the runtime.
                //        case sIndex:                   20 April 2026 #صح
                //            return 0;
                //    }
                //}
            }
            return counter;
        }
    }
}
