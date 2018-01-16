using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var count = 0;
            for (int i = 0; i < n.Count; i++)
            {
                if (n[i] == 0)
                {
                    count++;
                    continue;
                }
                var index = n[i];
                n[i] = 0;
                i = index - 1;
            }
            Console.WriteLine(count);
        }
    }
}
