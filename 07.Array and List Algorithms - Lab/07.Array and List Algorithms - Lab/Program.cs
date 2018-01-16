using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Array_and_List_Algorithms___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            bool isContain = false;

            for (int i = 0; i < listNumbers.Count; i++)
            {
                if (listNumbers[i] == n)
                {
                    isContain = true;
                }
            }
            if (isContain)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
