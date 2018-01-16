using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var newDict = new SortedDictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                long number;
                    if (input[0] == "Over")
                                {
                                    break;
                                }
                bool isNumeric = long.TryParse(input[2], out number);
                
                if (isNumeric == true)
                {
                  var  num = number.ToString();
                    newDict[input[0]] = num;
                }
                else
                {
                    newDict[input[2]] = input[0];
                }
                
            }
            foreach (var item in newDict)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
        }
    }
}
