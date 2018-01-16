using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diamond_Problem_te
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int leftIndex = -1;
            int rightIndex = -1;
            bool isFound = false;

            while ((leftIndex = input.IndexOf('<',leftIndex + 1)) > - 1
                && (rightIndex = input.IndexOf('>', leftIndex + 1)) > - 1)
            {
                string diamondContent = input.Substring(leftIndex + 1,rightIndex - leftIndex - 1);
                int carats = FindCarats(diamondContent);
                Console.WriteLine("Found {0} carat diamond",carats);
                isFound = true;
            }

            if (!isFound)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int FindCarats(string diamondContent)
        {
            int carats = 0;

            foreach (char @char in diamondContent)
            {
                if (char.IsDigit(@char))
                {
                    carats += @char - '0';
                  //  carats += int.Parse(@char.ToString());
                }
            }

            return carats;
        }
    }
}
