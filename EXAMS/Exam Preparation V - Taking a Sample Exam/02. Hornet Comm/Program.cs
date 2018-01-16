using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            var patternDig = @"^[0-9]+$";
            var patternPrivate = @"^\w+$";
            var anithing = @"[^0-9]+";

            var message = new List<string>();
            var broadcast = new List<string>();
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Hornet is Green")
                {
                    break;
                }
                if (input.Length < 2)
                {
                    break;
                }
                var first = input[0];
                var second = input[1];

                var matchDigPrivate = Regex.IsMatch(first, patternDig);
                var matchSecondPrivate = Regex.IsMatch(second, patternPrivate);
                var matchFirst = Regex.IsMatch(first, anithing);

                if (matchSecondPrivate == true && matchDigPrivate == true)
                {
                    var str = "";
                    string res = new string(first.ToCharArray().Reverse().ToArray());
                    str = $"{res} -> {second}";
                    message.Add(str);
                }
                if (matchFirst == true && matchSecondPrivate == true)
                {

                    var a = "";
                    string re = new string(second.ToCharArray().ToArray());
                    foreach (var item in re)
                    {
                        if (char.IsLower(item))
                        {
                            a += item.ToString().ToUpper();
                        }
                        else if (char.IsUpper(item))
                        {
                            a += item.ToString().ToLower();
                        }
                        else
                        {
                            a += item;
                        }
                    }
                    a = $"{a} -> {first}";
                    broadcast.Add(a);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\r\n", broadcast));
            }

            Console.WriteLine("Messages:");
            if (message.Count() == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join("\r\n", message));
            }

        }
    }
}
