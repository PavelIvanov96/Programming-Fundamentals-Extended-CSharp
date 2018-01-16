using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.SoftUni_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex messagePattern = new Regex(@"^\d+(?<massage>[A-Za-z]+)[^a-zA-Z]+$");
            string input = Console.ReadLine();

            while (input != "Decrypt!")
            {
                int validLength = int.Parse(Console.ReadLine());

                if (messagePattern.IsMatch(input))
                {
                    Match m = messagePattern.Match(input);
                    string message = m.Groups["massage"].Value;

                    if (message.Length == validLength)
                    {
                        string decodedMassage = ADecodedMassage(input, message);
                        Console.WriteLine("{1} = {0}",decodedMassage,message);
                    }
                   
                }

                input = Console.ReadLine();
            }
        }
        static string ADecodedMassage(string input , string massage)
        {
            string result = "";
            foreach (var symbol in input)
            {
                int index = symbol - '0';
                if (char.IsDigit(symbol) && index < massage.Length)
                {
                    result += massage[symbol - '0'];
                }
            }
            return result;
        }
    }
}
