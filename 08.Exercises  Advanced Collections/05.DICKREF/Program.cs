using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DICKREF
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictRef = new Dictionary<string, List<int>>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] data = inputLine
                    .Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                string[] secondParam = data[1]
                    .Split(", ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                int number = 0;

                if (int.TryParse(secondParam[0], out number))
                {

                    if (!dictRef.ContainsKey(name))
                    {
                        dictRef[name] = new List<int>();
                    }

                    for (int i = 0; i < secondParam.Length; i++)
                    {
                        dictRef[name].Add(int.Parse(secondParam[i]));
                    }
                }
                else
                {
                    if (dictRef.ContainsKey(secondParam[0]))
                    {
                        dictRef[name] = new List<int>(dictRef[secondParam[0]]);
                    }
                }
                inputLine = Console.ReadLine();
            }


            //Print the result
            foreach (var name in dictRef)
            {
                Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");
            }
        }
    }
}
