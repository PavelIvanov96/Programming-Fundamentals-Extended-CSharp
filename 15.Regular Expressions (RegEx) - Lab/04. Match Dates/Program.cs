using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})([\/|\-|.])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

            var input = Console.ReadLine();

            var dates = Regex.Matches(input, regex);

            foreach (Match item in dates)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",day,month,year);
            }
        }
    }
}
