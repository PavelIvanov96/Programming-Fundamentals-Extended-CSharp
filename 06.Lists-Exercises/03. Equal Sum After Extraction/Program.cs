using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> diffList = secondList;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int k = 0; k < secondList.Count; k++)
                {
                    if (firstList[i] == secondList[k])
                    {
                        diffList.Remove(firstList[i]);
                    }
                }
            }
            long sumFirstList = 0L;
            foreach (int number in firstList)
            {
                sumFirstList += number;
            }
            long sumSecondList = secondList.Sum();
            
            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine("Yes. Sum: {0}",sumFirstList);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}",Math.Abs(sumFirstList - sumSecondList));
            }
            
        }
    }
}
