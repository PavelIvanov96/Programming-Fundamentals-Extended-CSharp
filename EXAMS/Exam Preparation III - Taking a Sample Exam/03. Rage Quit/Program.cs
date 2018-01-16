using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = @"([^0-9]+)([0-9]+)";
            var match = Regex.Matches(input, regex);
            StringBuilder result = new StringBuilder();
            
            foreach (Match item in match)
            {
                var str = item.Groups[1].Value.ToString().ToUpper();
                var count = int.Parse(item.Groups[2].Value);
                
                for (int i = 0; i < count; i++)
                {
                    result.Append(str);
                }
            }
            var cnt = result.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}",cnt);
            Console.WriteLine(result);
        }
    }
}
