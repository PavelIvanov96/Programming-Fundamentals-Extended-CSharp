using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int countOfLists = int.Parse(Console.ReadLine());

            List<int> newList = new List<int>();

            for (int i = 0; i < countOfLists; i++)
            {
                List<int> integersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int k = 0; k < integersList.Count; k++)
                {
                   if (primalList.Contains(integersList[k]))
                     {
                        primalList.RemoveAll(item => item == integersList[k]);
                     }
                    else
                    {
                        primalList.Add(integersList[k]);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(String.Join(" ",primalList));
        }
    }
}
