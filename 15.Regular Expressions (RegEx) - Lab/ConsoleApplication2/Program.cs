using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matchedNames = Regex.Matches(input, regex);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
