using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Test
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

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes");

                foreach (var kvp in color.Value)
                {
                    count++;
                    Console.WriteLine($"* {string.Join("|| ", color.Value)}");
                    // foreach (var item in kvp)
                    // {
                    //     string first =
                    //     Console.WriteLine($"* {item} - {count}");
                    // }
                }
            }
        }
    }
}
