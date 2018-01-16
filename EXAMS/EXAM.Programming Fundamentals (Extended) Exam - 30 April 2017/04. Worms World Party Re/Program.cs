using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party_Re
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary <string,long>>();

            while (true)
            {
                var tokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var isContaints = false;
                if (tokens[0] == "quit")
                {
                    break;
                }
                var name = tokens[0];
                var teamName = tokens[1];
                var score = int.Parse(tokens[2]);

                foreach (var item in players)
                {
                    foreach (var kvp in item.Value)
                    {
                        if (kvp.Key == name)
                        {
                            isContaints = true;
                        }
                    }
                }
                if (!isContaints)
                {
                    if (!players.ContainsKey(teamName))
                    {
                        players[teamName] = new Dictionary<string, long>();
                    }
                    if (!players[teamName].ContainsKey(name))
                    {
                        players[teamName][name] = 0;
                    }
                    players[teamName][name] = score;
                }
                
            }
            var cnt = 0;
            foreach (var item in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Values.Count))
            {
                cnt++;
                Console.WriteLine("{0}. Team: {1} - {2}",cnt,item.Key,item.Value.Values.Sum());
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("###{0} : {1}",kvp.Key,kvp.Value);
                }
            }
        }
    }
}
