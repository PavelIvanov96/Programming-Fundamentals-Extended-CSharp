﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    count++;
                }
                catch 
                {
                    Console.WriteLine("{0}",count);
                    break;
                } 
            }
        }
    }
}
