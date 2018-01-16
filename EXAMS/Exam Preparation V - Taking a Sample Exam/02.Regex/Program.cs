using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var patternDig = @"^[0-9]+$";
            var patternPrivate = @"[A-Za-z]+[0-9]+?$";

            var message = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Hornet is Green")
                {
                    break;
                }

                var first = input[0];
                var second = input[1];

                var matchDigPrivate = Regex.IsMatch(first, patternDig);
                var matchSecondPrivate = Regex.IsMatch(second, patternPrivate);

                if (matchDigPrivate == true && matchSecondPrivate == true)
                {
                    var res = new string(first.ToCharArray.Reverse().ToArray);
                    if (!message.ContainsKey(first))
                    {
                        message[first] = new string();
                    }
                    message[first] = new string();
                }
            }
            foreach (var item in message)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
