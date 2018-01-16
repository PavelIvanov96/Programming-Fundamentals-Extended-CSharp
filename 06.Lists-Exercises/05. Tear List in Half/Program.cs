using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            List<int> fullList = new List<int>();
            var first = 0;
            var last = 0;

            for (int i = 0; i < input.Count/ 2; i++)
            {
                firstList.Add(input[i]);
            }
            for (int i = input.Count / 2; i < input.Count; i++)
            {
                secondList.Add(input[i]);
            }
            for (int i = 0; i < input.Count / 2; i++)
            {
                first = secondList[i] / 10;
                last = secondList[i] % 10;

                fullList.Add(first);
                fullList.Add(firstList[i]);
                fullList.Add(last);
            }
            Console.WriteLine(String.Join(" ",fullList ));
        }
    }
}
