using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var firstDic = new Dictionary<string,Dictionary<string,long>>();
            var secondDid = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var lastActivity =long.Parse(tokens[0]);
                var legionName = tokens[1];
                var soldierType = tokens[2];
                var soldierCount = long.Parse(tokens[3]);

                if (!firstDic.ContainsKey(legionName))
                {
                    firstDic.Add(legionName, new Dictionary<string, long>());
                    secondDid.Add(legionName, lastActivity);
                }
                if (!firstDic[legionName].ContainsKey(soldierType))
                {
                    firstDic[legionName][soldierType] = 0;
                }
                if (secondDid[legionName] < lastActivity)
                {
                    secondDid[legionName] = lastActivity;
                }
                firstDic[legionName][soldierType] += soldierCount;
                
            }
            var command = Console.ReadLine().Split('\\');
            if (command.Length == 1)
            {
                foreach (var item in secondDid.OrderByDescending(x => x.Value))
                {
                    if (firstDic[item.Key].ContainsKey(command[0]))
                    {
                        Console.WriteLine(item.Value + " : " + item.Key);
                    }
                }
            }
            else
            {
                long searchActivity = long.Parse(command[0]);
                var searchName = command[1];

                foreach (var item in firstDic.Where(l => l.Value.ContainsKey(searchName))
                    .OrderByDescending(l => l.Value[searchName]))
                {
                    if (secondDid[item.Key] < searchActivity)
                    {
                        Console.WriteLine("{0} -> {1}",item.Key,item.Value[searchName]);
                    }
                }

            }
          
            //  foreach (var item in firstDic)
            //  {
            //      Console.WriteLine(item.Key);
            //  }

        }
    }
}
