using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cnt = int.Parse(Console.ReadLine());
            var dataBase = new Dictionary<string, List<double>>();

            for (int i = 0; i < cnt; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);
                if (!dataBase.ContainsKey(name))
                {

                    dataBase.Add(name, new List<double>());
                }
                dataBase[name].Add(grade);
            }

            foreach (var item in dataBase)
            {
                double sum = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    sum += item.Value[i];
                }
                double avrg = sum / item.Value.Count;

                Console.Write($"{item.Key} -> ");
             
                foreach (var res in item.Value)
                {
                    Console.Write($"{res:f2} ");
                }
             
                
            }
        }
    }
}
