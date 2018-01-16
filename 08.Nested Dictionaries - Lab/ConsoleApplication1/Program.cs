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
            int n = int.Parse(Console.ReadLine());
            // color -> list of clothes
            Dictionary<string, HashSet<string>> wardrobe = new Dictionary<string, HashSet<string>>();
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string color = input[0];

                string dresVariable = input[2];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new HashSet<string>();
                }
                wardrobe[color].Add(dresVariable);

            }
        }
    }
}
