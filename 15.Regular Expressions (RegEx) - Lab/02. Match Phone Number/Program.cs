using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = @"\+359([ -])2\1\d{3}\1\d{4}\b"; ;
            var mathes = Regex.Matches(input, regex);

            var castMatches = mathes.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",castMatches));
        }
    }
}   
