using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var cnt = pattern.Length;
            var dicTopScores = new Dictionary<string, long>();
            var dicTopPoints = new Dictionary<string, long>();

            while (true)
            {
                var input = Console.ReadLine();
                
                if (input == "final")
                {
                    break;
                }
                var stats = input.Split(' ');
                var score = stats[stats.Length - 1];
                var goals = score.Split(':');
                var first = int.Parse(goals[0]);
                var last = int.Parse(goals[1]);


                var result = Regex.Matches(input, $@"[{pattern}]{{{cnt}}}([A-Za-z])*[{pattern}]{{{cnt}}}");

                StringBuilder words = new StringBuilder();
                foreach (Group item in result)
                {
                    var to = item.ToString();
                    var toStr = new string(to.ToCharArray().ToArray());
                    for (int i = toStr.Length - cnt - 1; i > cnt - 1; i--)
                    {
                        words.Append(toStr[i]);
                    }
                    words.Append(" ");
                }
                var teams = words.ToString().Split(' ');
                var firstTeam = teams[0].ToUpper();
                var secondTeam = teams[1].ToUpper();

                if (!dicTopPoints.ContainsKey(firstTeam))
                {
                    dicTopPoints[firstTeam] = 0;
                }
                if (!dicTopPoints.ContainsKey(secondTeam))
                {
                    dicTopPoints[secondTeam] = 0;
                }

                if (first < last)
                {
                    dicTopPoints[secondTeam] += 3;
                }
                else if (first > last)
                {
                    dicTopPoints[firstTeam] += 3;
                }
                else if (first == last)
                {
                    dicTopPoints[firstTeam] += 1;
                    dicTopPoints[secondTeam] += 1;
                }

                if (!dicTopScores.ContainsKey(firstTeam))
                {
                    dicTopScores[firstTeam] = 0;
                }
                    dicTopScores[firstTeam] += first;
               
                if (!dicTopScores.ContainsKey(secondTeam))
                {
                    dicTopScores[secondTeam] = 0;
                }
                   dicTopScores[secondTeam] += last;
                
            }
            var c = 1;
            Console.WriteLine("League standings:");
            foreach (var item in dicTopPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{2}. {0} {1}",item.Key,item.Value,c);
                c++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in dicTopScores.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine("- {0} -> {1}",item.Key,item.Value);
            }
       }
    }
}
