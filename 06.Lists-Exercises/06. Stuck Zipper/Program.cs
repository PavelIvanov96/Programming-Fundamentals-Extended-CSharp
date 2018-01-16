using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstListInput = Console.ReadLine().Split(' ').ToList();
            List<string> secondListInput = Console.ReadLine().Split(' ').ToList();
           
            List<string> zipperList = new List<string>();
            var minLenght = int.MinValue;

            for (int i = 0; i < firstListInput.Count; i++)
            {
                if (minLenght <= firstListInput[i].Length)
                {
                    minLenght = firstListInput[i].Length;
                }
            }
            for (int i = 0; i < secondListInput.Count; i++)
            {
                if (minLenght <= secondListInput[i].Length)
                {
                    minLenght = secondListInput[i].Length;
                }
            }

            var maxCount = Math.Max(firstListInput.Count, secondListInput.Count);

            for (int i = 0; i < firstListInput.Count; i++)
            {
                    if (minLenght <= firstListInput[i].Length)
                    {
                    firstListInput.Remove(firstListInput[i]);
                    i--;
                    }
            }
            for (int i = 0; i < secondListInput.Count; i++)
            {
                if (minLenght <= secondListInput[i].Length)
                {
                    secondListInput.Remove(secondListInput[i]);
                    i--;
                }
            }


            for (int i = 0; i < maxCount; i++)
            {
                if (i < secondListInput.Count)
                {
                    zipperList.Add(secondListInput[i]);
                }
                if (i < firstListInput.Count)
                {
                    zipperList.Add(firstListInput[i]);
                }
            }
            Console.WriteLine(String.Join(" ",zipperList));
            
            
        }
    }
}
