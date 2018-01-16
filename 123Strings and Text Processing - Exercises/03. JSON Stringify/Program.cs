using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Stringify
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder bilder = new StringBuilder();
            
            bilder.Append("[");
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " ->" }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "stringify")
                {
                    break;
                }

                var split = input[0].Split(new char[] { ':' ,' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = split[0].Trim();
                var age = split[1].Trim();

               
                  var  grades = input[1].Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

                bilder.Append(string.Format("{{name:\"{0}\",age:{1},grades:[{2}]}},", name, age, string.Join(", ", grades)));
                

            }
            bilder.Remove(bilder.Length - 1, 1);
            bilder.Append("]");
            Console.WriteLine(bilder.ToString());

        }
    }
}
