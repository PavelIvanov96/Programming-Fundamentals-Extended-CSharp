using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var input = Console.ReadLine();
            var match = Regex.Matches(input, regex);

            foreach (Match item in match)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
