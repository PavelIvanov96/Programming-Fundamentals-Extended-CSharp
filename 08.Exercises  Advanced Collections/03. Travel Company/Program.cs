using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var dic = new Dictionary<string, Dictionary<string, int>>();
            var timeDic = new Dictionary<string, int>();

            while (true)
            {
                var firstInput = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (firstInput[0] == "ready")
                {
                    break;
                }

                var town = firstInput[0];
                var firstSplit = firstInput[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


                foreach (var item in firstSplit)
                {
                    var secondSplit = item.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (!dic.ContainsKey(town))
                    {
                        dic[town] = new Dictionary<string, int>();
                    }

                    dic[town][secondSplit[0]] = int.Parse(secondSplit[1]);
                }
            }
            while (true)
            {
                var travelTime = Console.ReadLine().Split(' ');
                if (travelTime[0] == "travel" && travelTime[1] == "time!")
                {
                    break;
                }
                var town = travelTime[0];
                var numb = int.Parse(travelTime[1]);
                if (!timeDic.ContainsKey(town))
                {
                    timeDic[town] = new int();
                }
                timeDic[town] = numb;
            }


            foreach (var item in timeDic)
            {
                foreach (var kvp in dic)
                {
                    var sum = kvp.Value.Sum(v => v.Value);

                    if (item.Key == kvp.Key && item.Value <= sum)
                    {
                        Console.WriteLine("{0} -> all {1} accommodated", item.Key, item.Value);
                    }
                    if (item.Key == kvp.Key && item.Value > sum)
                    {
                        var result = item.Value - sum;
                        Console.WriteLine("{0} -> all except {1} accommodated", item.Key, result);
                    }
                }
            }
        }
    }
}
