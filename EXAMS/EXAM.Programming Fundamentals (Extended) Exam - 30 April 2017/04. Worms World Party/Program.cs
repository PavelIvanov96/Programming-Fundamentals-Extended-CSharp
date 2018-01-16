using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string,Dictionary<string,long>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " -> " },StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "quit")
                {
                    break;
                }

                var name = input[0];
                var team = input[1];
                var score = long.Parse(input[2]);
                if (!dic.ContainsKey(team))
                {
                    dic[team] = new Dictionary<string, long>();
                }
                dic[team][name] = score;
            }
               var result = dic.Values.OrderBy(x => x.Keys).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("Team: {0} - ",item);
                Console.WriteLine(item.Values.Sum());
                foreach (var kvp in item.Values)
                {
                    Console.WriteLine("###{0} : ",kvp);
                   
                }
            }
            
        }
    }
}
