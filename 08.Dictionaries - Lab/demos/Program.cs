using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }

            var oddNumber = new List<string>();

            foreach (var kvp in result)
            {
                var value = kvp.Value;
                if (value % 2 != 0)
                {
                    oddNumber.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",oddNumber));
        }
    }
}
