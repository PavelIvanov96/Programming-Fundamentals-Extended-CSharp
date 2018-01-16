using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, double>();
            var dicNames = new Dictionary<string, List<string>>();

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
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { (": ") }, StringSplitOptions.RemoveEmptyEntries );
                if (input[0] == "Print")
                {
                    break;
                }
                if (input[0] == "Discount")
                {

                }
                var name = input[0];
                var split = input[1].Split(new string[] { (", ") }, StringSplitOptions.RemoveEmptyEntries);

                if (!dicNames.ContainsKey(name))
                {
                    dicNames[name] = new List<string>();
                }
                foreach (var product in split)
                {
                    dicNames[name].Add(product);
                }
            }
        }
    }
}
