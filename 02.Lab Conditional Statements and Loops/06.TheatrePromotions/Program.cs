﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            double age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            if (typeOfDay == "weekday")
            {
                if (age >=0 && age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (age > 18 && age <=64)
                {
                    Console.WriteLine("18$");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("12$");
                }
            }
            else if (typeOfDay == "weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("15$");
                }
            }
            else if (typeOfDay == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("10$");
                }   
            }
        }
    }
}
