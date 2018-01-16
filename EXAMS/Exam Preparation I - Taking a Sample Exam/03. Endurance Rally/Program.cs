using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {


            var names = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var indexs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < names.Length; j++)
            {
                var sum = (double) (names[j].First());

                for (int i = 0; i < zones.Count(); i++)
                {
                    if (indexs.Contains(i))
                    {
                        sum += zones[i];
                    }
                    else
                    {
                        sum -= zones[i];
                    }
                    if (sum <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}",names[j], i);
                        break;
                    }
                }
                if (sum > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:F2}",names[j],sum);
                }
            }
        }
    }
}
