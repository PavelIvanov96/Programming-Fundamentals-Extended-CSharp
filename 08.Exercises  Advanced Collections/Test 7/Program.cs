using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<int, Dictionary<int, Dictionary<string, List<string>>>>>();

            dic["pesho"] = new Dictionary<int, Dictionary<int, Dictionary<string, List<string>>>>();
            dic["pesho"][1] = new Dictionary<int, Dictionary<string, List<string>>>();
            dic["pesho"][1][1] = new Dictionary<string, List<string>>();
            dic["peshp"][1][1][]

            foreach (var  item in dic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(string.Join(" ",item.Value));
            }
        }
    }
}
