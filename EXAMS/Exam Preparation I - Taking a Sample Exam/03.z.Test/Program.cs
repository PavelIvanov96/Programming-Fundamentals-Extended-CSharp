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
            var drivers = Console.ReadLine().Split(' ').ToList();

            var trackLayout = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToList();

            var checkpoint = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
          //  var result = new Dictionary<string, double>();

            double number = 0;
            for (int i = 0; i < drivers.Count; i++)
            {
                
                char firstLetter = drivers[i][0];
                number = (int)firstLetter;

                for (int j = 0; j < trackLayout.Count; j++)
                {
                    if (checkpoint.Contains(j))
                    {
                        number += trackLayout[j];
                    }
                    else
                    {
                        number -= trackLayout[j];
                        if (number <= 0)
                        {
                            Console.WriteLine("{0} - reached {1}",drivers[i],j);
                            break;
                        }
                    }
                }
                if (number > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}",drivers[i],number);
                }
                
            }
          //  foreach (var item in result)
          //  {
          //      if (item.Value > 0)
          //      {
          //          Console.WriteLine($"{item.Key} - fuel left {item.Value:f2}");
          //      }
          //      else
          //      {
          //          Console.WriteLine($"{item.Key} - reached 0");
          //      }
          //  }
        }
    }
}