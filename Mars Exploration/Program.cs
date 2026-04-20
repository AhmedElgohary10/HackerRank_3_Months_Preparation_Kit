using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Mars_Exploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "SOSSPSSQSSSR";
            MyDelegate d = new(Result.marsExploration);

            d.Display(s);
        }
    }
}
