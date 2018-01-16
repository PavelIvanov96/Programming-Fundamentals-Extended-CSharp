using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class Program
    {
        static void Main(string[] args)
        {

            var resultDic = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var tokens = Console.ReadLine().Split(new string[] { " -> "},StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "quit")
                {
                    break;
                }

                var country = tokens[0];
                var spyName = tokens[1];
                var days = int.Parse(tokens[2]);

                if (!resultDic.ContainsKey(country))
                {
                    resultDic[country] = new Dictionary<string, int>();
                }
                if (!resultDic[country].ContainsKey(spyName))
                {
                    resultDic[country][spyName] = 0;
                }
                resultDic[country][spyName] = days;
            }

            foreach (var item in resultDic.OrderByDescending(x => x.Value.Keys.Count()))
            {
                Console.WriteLine("Country: {0}",item.Key);
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("**{0} : {1}",kvp.Key,kvp.Value);
                   // Console.WriteLine(kvp.Value);
                }
            }
        }
    }
}
