using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var boyPattern = @"[A-Za-z]+\-[A-Za-z]+";
            var girlPattern = @"[^A-Za-z\-]+";

            var input = Console.ReadLine();
            while (true)
            {
                var girlMatches = Regex.Match(input, girlPattern);
                if (!Regex.IsMatch(input, girlPattern))
                {
                    break;
                }
                input = input.Remove(0, girlMatches.Index + girlMatches.Length);
                Console.WriteLine(girlMatches);
                
                var boyMatches = Regex.Match(input, boyPattern);
                if (!Regex.IsMatch(input, boyPattern))
                {
                    break;
                }
                Console.WriteLine(boyMatches);
                input = input.Remove(0, boyMatches.Index + boyMatches.Length);
            }
        }
    }
}
