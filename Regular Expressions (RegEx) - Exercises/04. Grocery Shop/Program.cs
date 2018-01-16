using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^[A-Z]{1}[a-z]+:[0-9]+.[0-9]{2}$";
            var dic = new Dictionary<string, double>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "bill")
                {
                    break;
                }
                var matches = Regex.Matches(input, pattern);

                foreach (Match products in matches)
                {
                    var split = products.ToString().Split(':');
                    var product = split[0];
                    var cost = double.Parse(split[1]);

                    if (dic.ContainsKey(product))
                    {
                        dic[product] = new double();
                    }
                    dic[product] = cost;
                }
            }
            foreach (var kvp in dic.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} costs {1:F2}",kvp.Key,kvp.Value);
            }
        }
    }
}
