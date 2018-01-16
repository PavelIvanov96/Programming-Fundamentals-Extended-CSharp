using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, double>();
           // var dicNames = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                if (input[0] == "Shop" && input[1] == "is" && input[2] == "open")
                {
                    break;
                }
                var product = input[0];
                var price = double.Parse(input[1]);
                if (!dic.ContainsKey(product))
                {
                    dic[product] = new double();
                }
                dic[product] = price;
            }
            foreach (var item in dic.OrderByDescending(x => x.Value).Take(3))
            {
                var discount = item.Value;
                    discount = discount * 0.90;

                for (int i = 0; i < 14; i++)
                {
                    
                }
                
                
                
                
            }
        }
    }
}
