using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a(.*href=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";
            var input = Console.ReadLine();
            var match = Regex.Matches(input, pattern);

            foreach (Match item in match)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
