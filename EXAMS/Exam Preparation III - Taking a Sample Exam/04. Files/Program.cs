using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split('\\');
                var data = tokens.Last().Split(';');
                var fileName = data[0];
                var fileSize = long.Parse(data.Last());
               

                if (!dic.ContainsKey(tokens[0]))
                {
                    dic.Add(tokens[0], new Dictionary<string, long>());
                }
                if (!dic[tokens[0]].ContainsKey(fileName))
                {
                    dic[tokens[0]].Add(fileName, fileSize);
                }
                else
                {
                    dic[tokens[0]][fileName] = fileSize;
                }

            }
            var contain = Console.ReadLine().Split(new string[] { " in " },StringSplitOptions.RemoveEmptyEntries);
            var file = contain[0];
            var folder = contain[1];

            if (dic.ContainsKey(folder))
            {
                Dictionary<string, long> foundFiles = dic[folder];
                foreach (var item in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (item.Key.EndsWith(file))
                    {
                        Console.WriteLine("{0} - {1} KB",item.Key,item.Value);
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
