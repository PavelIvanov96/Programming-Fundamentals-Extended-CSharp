using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dic_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();

            var input = Console.ReadLine().Split(new char[] { ' ', '=' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end")
            {
                string keyInput = input[0];
                string valueInput = input[1];
                int numValue;

                if (int.TryParse(valueInput,out numValue))
                {
                    dic[keyInput] = numValue;
                }
                else
                {
                    if (dic.ContainsKey(valueInput))
                    {
                        dic[keyInput] = dic[valueInput];
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0} === {1}",item.Key,item.Value);
            }
        }
    }
}
