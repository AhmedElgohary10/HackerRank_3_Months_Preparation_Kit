namespace Camel_Case_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output = string.Empty;

            while ((input = Console.ReadLine()) != null)
            {
                string[] arr = input.Split(";");

                if (arr[0] == "S")
                {
                    List<string> words = new List<string>();
                    switch (arr[1])
                    {
                        case "M":
                            string methodName = arr[2].Split("(")[0];
                            words = Solution.SplitCamel(methodName);
                            break;
                        case "C":
                            string className = arr[2];
                            string calssNameAsMethod
                                = className[0].ToString().ToLower()
                                    + className.Split(className[0], 2)[1];
                            words = Solution.SplitCamel(calssNameAsMethod);
                            break;
                        case "V":
                            string varName = arr[2];
                            words = Solution.SplitCamel(varName);
                            break;
                    }
                    foreach (string word in words)
                    {
                        output += word + " ";
                    }
                }
                else if (arr[0] == "C")
                {
                    switch (arr[1])
                    {
                        case "M":
                            //C;M;white sheet of paper
                            // => whiteSheetOfPaper()
                            output = Solution.JoinCamel(arr[2]) + "()";
                            break;
                        case "C":
                            //C;C;coffee machine
                            // => CoffeeMachine
                            // code swarm
                            output = Solution.JoinCamel(arr[2][0].ToString().ToUpper() + arr[2].Split(arr[2][0], 2)[1]);
                            //Console.WriteLine(output);

                            break;
                        case "V":
                            //C;V;mobile phone
                            output = Solution.JoinCamel(arr[2]); // arr[2] = "mobile phone"
                            break;
                    }
                }
                Console.WriteLine(output);
                output = string.Empty;
            }
        }
    }
}



/*
S;V;iPad
C;M;mouse pad
C;C;code swarm
S;C;OrangeHighlighter
 */

/*
========= Sample Input

S;M;plasticCup()

C;V;mobile phone

C;C;coffee machine

S;C;LargeSoftwareBook

C;M;white sheet of paper

S;V;pictureFrame

========= Sample Output

plastic cup

mobilePhone

CoffeeMachine

large software book

whiteSheetOfPaper()

picture frame
*/