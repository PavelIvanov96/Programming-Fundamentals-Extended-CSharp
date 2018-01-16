using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " -> "},StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "filter")
                {
                    break;
                }
                var name = input[0];
                var split = input[1].Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries);
                if (!dic.ContainsKey(name))
                {
                    dic[name] = new HashSet<string>();
                }
                foreach (var item in split)
                {
                    var i = item.Trim();
                    dic[name].Add(i);
                }
            }

            var key = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var cnt = 0;
            var count = 0;
            foreach (var kvp in dic)
            {
                     count = 0;
                foreach (var item in key)
                {
                   
                    if (kvp.Value.Contains(item))
                    {
                        count++;
                       // Console.WriteLine(count);
                    }
                }
                if (count == key.Count())
                {
                Console.Write("{0} | ",kvp.Key);
                foreach (var item in kvp.Value)
                {
                        cnt++;
                    if (cnt == kvp.Value.Count )
                    {
                        Console.Write("#{0} ", item);
                    }
                    else
                    {
                        Console.Write("#{0}, ", item);
                    }
                }
                Console.WriteLine();
                    cnt = 0;
                }
                
            }
        }
    }
}
