using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var newInput = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                if (input[0] == "end")
                {
                    break;
                }
                newInput[input[0]] = input[2];
            }
            foreach (var item in newInput)
            {
                foreach (var pens in newInput)
                {
                    if (pens.Value == item.Key)
                    {
                        Console.WriteLine("{0}  {1}  {2} {3}",pens.Key,item.Key,pens.Value,item.Value);
                        //Console.WriteLine("{0} === {1}",pens.Key,item.Value);
                    }
                }
               // Console.WriteLine("{0} === {1}", item.Key, item.Value);
            }
        }
    }
}
