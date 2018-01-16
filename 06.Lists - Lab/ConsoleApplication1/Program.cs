using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> lists = new List<int>();
            bool isListEmpty = true;

            for (int i = 0; i < numbs.Count; i++)
            {
                if (numbs[i] > 0)
                {
                    lists.Add(numbs[i]);
                    isListEmpty = false;
                }
            }

            lists.Reverse();
            if (isListEmpty == true)
            {
                Console.WriteLine("empty");
            }
            else
            {
                 Console.WriteLine(String.Join(" ", lists));
            }
            
        }
    }
}
