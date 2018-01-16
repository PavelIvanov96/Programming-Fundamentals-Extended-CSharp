﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberToFind = int.Parse(Console.ReadLine());

            int countLinearSearch = LinearSearch(numbers, numberToFind);
            int binarysearchCount = BinarySearch(numbers, numberToFind);
            numbers.Sort();
            if (numbers.BinarySearch(numberToFind) >= 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine("Linear search made {0} iterations",countLinearSearch);
            Console.WriteLine("Binary search made {0} iterations",binarysearchCount);
        }

        private static int BinarySearch(List<int> numbers, int numberToFind)
        {
            numbers.Sort();
            int min = 0;
            int max = numbers.Count - 1;
            int count = 0;
            while (min <= max)
            {
                int midPoint = (min + max) / 2;
                count++;
                if (numbers[midPoint] < numberToFind)
                {
                    min = midPoint + 1;
                }

                if (numbers[midPoint] > numberToFind)
                {
                    max = midPoint - 1;
                }

                if (numbers[midPoint] == numberToFind)
                {
                    break;
                }
            }
            return count;
        }

        static int LinearSearch(List<int> numbers, int numberstoFind)
        {
            int count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                count++;
                if (numbers[i] == numberstoFind)
                {
                    return count;
                }
            }
            return count;
        }
    }
}
