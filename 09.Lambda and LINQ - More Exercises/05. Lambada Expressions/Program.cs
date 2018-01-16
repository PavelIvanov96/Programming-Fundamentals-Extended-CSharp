using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string,string>>();
            var isDance = false;
            var cnt = 1;
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "lambada")
                {
                    break;
                }
                if (input[0] == "dance")
                {
                    cnt++;
                    isDance = true;
                    
                }
                else
                {
                    var split = input[1].Split('.');
                    if (!dic.ContainsKey(input[0])) 
                    {
                        dic[input[0]] = new Dictionary<string, string>(); 
                    }
                    dic[input[0]][split[0]] = split[1];
                }
            }
            if (isDance == false)
            {
            foreach (var item in dic)
                {
                    Console.Write("{0} => ",item.Key);
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine("{0}.{1}",kvp.Key,kvp.Value);
                }
                }                
            }
            else
            {
                foreach (var item in dic)
                {
                    Console.Write("{0} => ", item.Key);
                    foreach (var kvp in item.Value)
                    {
                        for (int i = 0; i < cnt; i++)
                        {
                            Console.Write("{0}.",kvp.Key);
                        }
                        Console.WriteLine("{0}", kvp.Value);

                    }
                }
            }
        }
    }
}
