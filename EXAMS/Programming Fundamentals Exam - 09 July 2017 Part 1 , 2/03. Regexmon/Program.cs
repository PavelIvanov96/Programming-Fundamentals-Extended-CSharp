using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var bojoPattern = @"([A-Za-z]+\-[A-Za-z]+)";
            var girlPattern = @"[^A-Za-z\-]+";
            var input = Console.ReadLine();

            while (true)
            {
                var girlMatch = Regex.Match(input, girlPattern);
               
                if (!Regex.IsMatch(input, girlPattern))
                {
                    break;
                }
                input = input.Remove(0, girlMatch.Index + girlMatch.Length);
                var bojoMatch = Regex.Match(input, bojoPattern);
                
                Console.WriteLine(girlMatch);
                Console.WriteLine(bojoMatch);
               
                if (!Regex.IsMatch(input, bojoPattern))
                {
                    break;
                }
                input = input.Remove(0, bojoMatch.Index + bojoMatch.Length);
            }
        }
    }
}
