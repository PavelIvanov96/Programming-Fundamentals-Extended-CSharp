using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    class Program
    {
        static Char MostRepeated(string s)
        {
            int[] count = new int[1000000];
            int max = 0;
            char result = char.MinValue;

            Array.Clear(count, 0, count.Length - 1);

            foreach (char @char in s)
            {
                if (++count[@char] > max)
                {
                    max = count[@char];
                    result = @char;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            var pattern = @"^[A-Z][^.]*.{1}$";
            var wordPattern = @"[A-Za-z]+";
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Worm Ipsum")
                {
                    break;
                }
                var matches = Regex.Matches(input, pattern);
                StringBuilder result = new StringBuilder();

                foreach (Match item in matches)
                {
                    var sentence = item.Value.ToString();
                    var words = Regex.Matches(sentence, wordPattern);
                    foreach (Match word in words)
                    {
                        var wo = word.ToString();
                        if (wo.Distinct().Count() != wo.Count())
                        {
                            char @char = MostRepeated(wo);
                            var re = "";
                            for (int i = 0; i < wo.Length; i++)
                            {
                                re += @char;
                            }
                            if (sentence.Contains(wo))
                            {
                                sentence = sentence.Replace(wo , re);
                            }
                        }
                    }
                    Console.WriteLine(sentence.ToString());
                }
            }
        }
    }
}
