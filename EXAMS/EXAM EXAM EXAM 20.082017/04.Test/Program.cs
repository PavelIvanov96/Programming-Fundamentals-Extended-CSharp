using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "It's Training Men!")
                {
                    break;
                }
                if (input.Contains(':'))
                {
                    var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    var trainName = tokens[0];
                    var wagons = tokens[1].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    var wagonName = wagons[0];
                    var wagonPower = long.Parse(wagons[1].Trim());

                    if (!dic.ContainsKey(trainName))
                    {
                        dic.Add(trainName, new Dictionary<string, long>());
                    }
                    if (!dic[trainName].ContainsKey(wagonName))
                    {
                        dic[trainName].Add(wagonName, 0);
                    }
                    dic[trainName][wagonName] = wagonPower;
                }
                else if (input.Contains('='))
                {
                    var tokens = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                    var first = tokens[0];
                    var other = tokens[1];
                    dic[first].Clear();

                    foreach (var item in dic[other])
                    {
                        if (!dic.ContainsKey(item.Key))
                        {
                            dic[first][item.Key] = item.Value;
                        }
                    }
                }
                else
                {
                    var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    var first = tokens[0];
                    var second = tokens[1];
                    foreach (var item in dic[second])
                    {
                        if (!dic.ContainsKey(first))
                        {
                            dic.Add(first, new Dictionary<string, long>());
                        }
                        dic[first].Add(item.Key, item.Value);
                    }
                    dic.Remove(second);
                }
            }

            foreach (var item in dic.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Value.Count()))
            {
                Console.WriteLine("Train: {0}", item.Key);
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("###{0} - {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
