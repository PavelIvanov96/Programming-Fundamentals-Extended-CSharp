using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var resultDic = new Dictionary<string, List<string>>();

            while (true)
            {
                var tokens = Console.ReadLine();
                var token = new string(tokens.ToCharArray());
                if (tokens == "END")
                {
                    break;
                }
                StringBuilder keys = new StringBuilder();
                while (true)
                {
                    if (keys.Length > token.Length)
                    {
                        break;
                    }
                    keys.Append(input);
                }
                var key = new string(keys.ToString().ToCharArray());
                var splitTokens = tokens.Split(' ').ToArray();
                var isName = true;
                if (splitTokens[0] == "TO:" && splitTokens[2] == "MESSAGE:")
                {
                    if (splitTokens[1].Trim(';') == splitTokens[1].Trim(';').ToUpper())
                    {
                        foreach (var item in splitTokens[1].Trim(';'))
                        {
                            if (item >= 65 && item <= 90)
                            {
                                isName = true;
                            }
                            else
                            {
                                isName = false;
                            }
                        }
                        if (isName)
                        {
                            StringBuilder res = new StringBuilder();

                            for (int i = 0; i < token.Length; i++)
                            {
                                var cript = (char)(token[i] + int.Parse(key[i].ToString()));
                                res.Append(cript);
                            }
                            if (!resultDic.ContainsKey(splitTokens[1]))
                            {
                                resultDic[splitTokens[1]] = new List<string>();
                            }
                            resultDic[splitTokens[1]].Add(res.ToString());
                        }
                    }
                }
            }
            foreach (var item in resultDic.OrderBy(x => x.Key))
            {
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine(kvp);
                }
            }
        }
    }
}
