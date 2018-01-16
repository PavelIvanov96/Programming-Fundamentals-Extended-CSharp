using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<int>>();
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                if (name == "end" )
                   {
                       break;
                   }
                var nums = input[1].Split(new string[] { ", "},StringSplitOptions.RemoveEmptyEntries);


                bool parsed = false;

                if (!dic.ContainsKey(name))
                {
                    dic[name] = new List<int>();
                }
                foreach (var item in nums)
                {
                    int outInt;
                     parsed = int.TryParse(item ,out outInt);
                    if (parsed == true)
                    {
                        dic[name].Add(outInt);
                    }
                    else
                    {
                        if (dic.ContainsKey(item))
                        {
                            dic[name] = dic[item];
                        }
                        else
                        {
                            dic.Remove(name);
                        }
                    }
                }
            }
            foreach (var kvp in dic)
            {
                Console.WriteLine("{0} === {1}",kvp.Key, string.Join(", ", kvp.Value));
            }
           
            }
    }
}
