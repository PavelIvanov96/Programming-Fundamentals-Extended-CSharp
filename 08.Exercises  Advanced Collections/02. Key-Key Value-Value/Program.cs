using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            string inputValue = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            var dic = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                var key = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                var keyFirst = key[0];
                var valueFirst = key[1];
                var split = valueFirst.Split(';');
                // bool result = Regex.IsMatch(keyFirst, inputKey);
                // Console.WriteLine(result);

                if (!dic.ContainsKey(inputValue))
                {
                    dic[keyFirst] = new List<string>();
                }
                foreach (var item in split)
                {
                    dic[keyFirst].Add(item);
                }
               
            }
            foreach (var kvp in dic)
            {
                if (kvp.Key.Contains(inputKey))
                {
                    Console.WriteLine("{0}:",kvp.Key);

            foreach (var item in kvp.Value)
                {
                    if (item.Contains(inputValue))
                    {
                        Console.WriteLine("-{0}",item);
                    }
                }
                }
                
                
            }
        }
    }
}
