using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                var distance = decimal.Parse(Console.ReadLine());
                var cargo = decimal.Parse(Console.ReadLine());
                var team = Console.ReadLine();
                if (team == "Technical" || team == "Theoretical" || team == "Practical")
                {
                    var milesToKm = distance * (decimal)1600;
                    var kg = cargo * (decimal)1000;
                    var kgPrice = Math.Round( kg * (decimal)1.5,3);
                    var milesPrice = Math.Round((decimal)0.7 * milesToKm * (decimal)2.5,3);
                    var participantEarnedMoney = (kgPrice - milesPrice);
                    if (!dic.ContainsKey(team))
                    {
                        dic[team] = new List<decimal>();
                    }
                    dic[team].Add(participantEarnedMoney);
                }
            }
            foreach (var item in dic.OrderByDescending(x => x.Value.Sum()).Take(1))
            {
                var sum = (decimal)0;
                foreach (var kvp in item.Value)
                {
                    sum += (decimal)kvp;
                }
                var gosho = Math.Round(sum, 3); ;
                Console.WriteLine("The {0} Trainers win with ${1:f3}.",item.Key,sum);
            }
        }
    }
}
