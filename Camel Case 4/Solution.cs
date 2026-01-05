using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_Case_4
{
    internal class Solution
    {
        public static List<string> SplitCamel(string name)
        {
            List<string> words = new List<string>();

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == Char.Parse(name[i].ToString().ToUpper()))
                {
                    string[] tempArr = name.Split(name[i],2);
                    words.Add(tempArr[0]);
                    name = name[i].ToString().ToLower() + tempArr[1];
                    i = 0;
                    //Console.WriteLine(name);
                }
            }
            words.Add(name);

            return words;
        }

        public static string JoinCamel(string name)
        {
            //"mobile phone for bebe bobo"
            string[] varName = name.Split(" "); //[mobile, phone, for, bla, bla, bla]
            string output = varName[0];

            for (int i = 1; i < varName.Length; i++)
            {
                output += Char.Parse(varName[i][0].ToString().ToUpper())
                + varName[i].Split(varName[i][0],2)[1];
            }

            return output;
        }

    }
}
