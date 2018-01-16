using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Select(x => (char)x).ToArray();
            var dic = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dic.ContainsKey(input[i]))
                {
                    dic[input[i]] = new List<int>();
                }
                dic[input[i]].Add(i);
            }

            foreach (var item in dic)
            {
                Console.Write("{0}:",item.Key);
                Console.WriteLine(string.Join("/",item.Value));
            }
        
        }
    }
}
