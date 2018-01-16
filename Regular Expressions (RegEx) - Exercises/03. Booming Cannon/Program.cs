using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Booming_Cannon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int distance = numbers[0];
            int countOfChars = numbers[1];
            var result = new List<string>();
            string element = "";
            string regex = @"(?<=\\<<<)[<]*[^\\<<<]+[<]*[^\\<<<]+";
            MatchCollection filteredInput = Regex.Matches(input, regex);
            foreach (var word in filteredInput)
            {
                element = "";
                if (distance <= word.ToString().Length)
                {
                    element = word.ToString().Substring(distance);
                    if (element.Length >= countOfChars)
                    {
                        element = element.Substring(0, countOfChars);
                    }
                }
                if (element != string.Empty)
                {
                    result.Add(element);
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join("/\\", result));
            }
        }
    }
}
