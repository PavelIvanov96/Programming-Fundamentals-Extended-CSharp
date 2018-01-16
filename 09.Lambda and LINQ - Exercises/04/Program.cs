using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string,int>>();
            //  var numDic = new Dictionary<string, int>();
            
            while (true)
            {
                var input = Console.ReadLine().Split('|');
                if (input[0] == "stop the game")
                {
                    break;
                }
                var teamPosition = input[0];
                var teamName = input[1];
                var teamPoints = int.Parse(input[2]);

                if (!dic.ContainsKey(teamName))
                {
                    dic[teamName] = new Dictionary<string, int>();
                }
                    dic[teamName][teamPosition] = teamPoints;
            }
            var cntt = 0;

            foreach (var item in dic.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var count = 0;
                
                foreach (var cnt in item.Value.Take(3))
                {
                    count++;
                }

            if (count == 3)
              {
                    cntt++;
                Console.WriteLine("{0}. {1}; Players:",cntt, item.Key);
                foreach (var kvp in item.Value.Take(3).OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("###{0}: {1}",kvp.Key,kvp.Value);
                }
              }
           }
        }
    }
}
