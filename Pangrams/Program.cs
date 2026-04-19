namespace Pangrams
{
    internal class Program
    {
        static string CountUniqueLetters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "not pangram";

            bool IsUniqe = true;
            List<char> uniqeLetters = new(26);
            string x = s.ToLower();
            uniqeLetters.Add(x[0]);

            foreach (char c in x)
            {
                IsUniqe = true;
                if (s.IndexOf(c) == 0)
                    continue;

                if (c.ToString() == " ")
                    continue;

                foreach (char uniqe in uniqeLetters)
                {
                    if (uniqe == c)
                        IsUniqe = false;
                }
                if (IsUniqe)
                    uniqeLetters.Add(c);
            }
            if (uniqeLetters.Count >= 26)
                return "pangram";

            return "not pangram";
        }

        static void Main(string[] args)
        {
            string s = "We promptly judged antique ivory buckles for the next prize";
            string s2 = "We promptly judged antique ivory buckles for the prize";

            Console.WriteLine(CountUniqueLetters(s));
            Console.WriteLine(CountUniqueLetters(s2));
            Console.WriteLine(CountUniqueLetters(""));
        }
    }
}
