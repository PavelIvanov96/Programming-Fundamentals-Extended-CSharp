using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            
                List<string> inputList = Console.ReadLine().Split(' ').ToList();
                List<char> newList = new List<char>();
            double totalSum = 0;
            double countOfCharacters = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                countOfCharacters += inputList[i].Length;

                for (int k = 0; k < inputList[i].Length; k++)
                {
                    totalSum += inputList[i][k];
                }
            }
            char charDelimeter = (char)((int)totalSum / countOfCharacters);
            string delimeter = charDelimeter.ToString().ToUpper();

            Console.WriteLine(string.Join(delimeter,inputList));

        }
    }
}
