using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> replace = new List<int>();

            int sum = 0;
            for (int i = 0; i < numbs.Count; i++)
            {
                if (i + 1 < numbs.Count - 1)
                {

                    if (numbs[i] == numbs[i + 1])
                    {
                        sum = numbs[i] + numbs[i];

                        numbs.RemoveAt(i);
                        numbs.RemoveAt(i);
                        numbs.Insert(i, sum);
                    }
                }
            }
        }
    }
}
