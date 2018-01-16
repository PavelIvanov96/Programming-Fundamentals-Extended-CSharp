using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberString = Console.ReadLine();
            var regex = @"\b(?:0x)?[0-9A-F]+\b";

            var numbers = Regex.Matches(numberString, regex).Cast<Match>().Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(" " ,numbers));
        }
    }
}
