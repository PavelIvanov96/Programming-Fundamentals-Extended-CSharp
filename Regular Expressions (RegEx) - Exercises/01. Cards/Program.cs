using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(?<=[SHDC]|^)([2-9JQKA]|10)[SHDC]";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input,regex);
            var lis = new List<object>();

            foreach (Match item in matches)
            {
                lis.Add(item);
            }
            Console.WriteLine(string.Join(", ",lis));
        }
    }
}
