using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var partyDic = new Dictionary<int, Dictionary<string, HashSet<string>>>();
            var booferDic = new Dictionary<string, SortedSet<string>>();

            while (true)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Time" && tokens[1] == "for" && tokens[2] == "Code")
                {
                    break;
                }
                var id =  int.Parse(tokens[0]);
                var eventName = tokens[1];

                if (!partyDic.ContainsKey(id))
                {
                    partyDic[id] = new Dictionary<string, HashSet<string>>();
                }
                if (!partyDic[id].ContainsKey(eventName))
                {
                    partyDic[id][eventName] = new HashSet<string>();
                }

                if (partyDic.ContainsKey(id))
                {
                    if (partyDic[id].Keys.Contains(eventName) )
                    {
                        foreach (var item in tokens.Skip(2))
                        {
                            partyDic[id][eventName].Add(item);
                        }
                    }
                }
            }

            foreach (var item in partyDic.OrderBy(x => x.Value.Values.Count))
            {
                foreach (var kvp in item.Value.OrderBy(x => x.Value.Count()))
                {
                    if (!booferDic.ContainsKey(kvp.Key))
                    {
                        booferDic[kvp.Key] = new SortedSet<string>();
                    }
                    foreach (var lis in kvp.Value)
                    {
                        booferDic[kvp.Key].Add(lis);
                    }
                }
            }

            foreach (var item in booferDic.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("{0} - {1}",item.Key.Trim('#'), item.Value.Count);
                Console.WriteLine(string.Join("\r\n",item.Value));
            }
        }
    }
}
