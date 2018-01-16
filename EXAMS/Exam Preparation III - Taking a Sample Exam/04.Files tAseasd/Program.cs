using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files_tAseasd
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < N; i++)
            {
                var tokens = Console.ReadLine().Split('\\');
                var token = tokens.Last().Split(';');
                var fileNames = token[0];
                long fileSize = long.Parse(token.Last());

                if (!result.ContainsKey(tokens[0]))
                {
                    result.Add(tokens[0], new Dictionary<string, long>());
                }
                if (!result[tokens[0]].ContainsKey(fileNames))
                {
                    result[tokens[0]].Add(fileNames, fileSize);
                }
                else
                {
                    result[tokens[0]][fileNames] = fileSize;
                }

            }

            var inputLine = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string extension = inputLine[0];
            string folder = inputLine[2];

            if (result.ContainsKey(folder))
            {
                Dictionary<string, long> final = result[folder];

                foreach (var item in final.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (item.Key.Contains(extension))
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                    }
                }
            }
            if (!result.ContainsKey(folder))
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
