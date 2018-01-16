using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, char>();

            while (true)
            {
                var input = Console.ReadLine().Split(':');
                if (input[0] == "end")
                {
                    break;
                }

                var letter = char.Parse(input[0]);
                var indexies = input[1].Split('/');

                foreach (var item in indexies)
                {
                    var toInt = int.Parse(item);
                    if (dic.ContainsKey(toInt))
                    {
                        dic[toInt] = new char();
                    }
                    dic[toInt] = letter;
                }
            }
            foreach (var item in dic.OrderBy(x => x.Key))
            {
                Console.Write(item.Value);
            }
            Console.WriteLine();
        }
    }
}
