using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var clothDic = new Dictionary<string, Dictionary<string,int>>();
            var count = 1;
            var countTo = "";
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var color = input[0];
                var cloths = input[1];
                var split = cloths.Split(',');

                foreach (var item in split)
                {
                        if (!clothDic.ContainsKey(color))
                        {
                            clothDic[color] = new Dictionary<string, int>();
                        }
                    if (!clothDic[color].ContainsKey(item))
                    {
                        clothDic[color][item] = 0;
                    }
                    clothDic[color][item]++; 
                }
            }
            var key = Console.ReadLine().Split(' ');
            var command = key[0];
            var clothCommand = key[1];

            foreach (var item in clothDic)
            {
                Console.WriteLine("{0} clothes: ",item.Key);
                foreach (var kvp in item.Value)
                {
                    if (item.Key == command && kvp.Key == clothCommand)
                    {
                        Console.WriteLine("* {0} - {1} (found!)", kvp.Key, kvp.Value);
                    }
                    else
                    {
                        Console.WriteLine("* {0} - {1}",kvp.Key,kvp.Value);
                    }
                }               
            }
        }
    }
}
