using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mars_Exploration
{
    internal static class Helpers
    {
        public static void Display(this MyDelegate d, string s)
        {
            Console.WriteLine(d.Invoke(s));
        }
    }
}
