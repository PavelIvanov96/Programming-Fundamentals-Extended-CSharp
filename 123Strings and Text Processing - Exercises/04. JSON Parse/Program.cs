using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            input = input.Substring(2, input.Length - 2 - 2);

            string[] tokens = input.Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                string[] properties = token.Split(new string[] { ",age:" , ",grades:"},StringSplitOptions.RemoveEmptyEntries);
                string name = properties[0].Substring(6 , properties[0].Length - 6 - 1);
                string age = properties[1];
                string greats = properties[2].Substring(1,properties[2].Length - 2);

                if (greats == string.Empty)
                {
                    greats = "None";
                }

                Console.WriteLine(name + " : " + age  +" -> " + greats);
            }
        }
    }
}
