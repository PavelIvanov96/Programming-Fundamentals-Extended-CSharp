using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var countChees = 0;
            var countSouce = 0;
            var countSalami = 0;
            var countPaper = 0; 

            for (int i = 0; i < n; i++)
            {
                string products = Console.ReadLine().ToLower();
                if (products == "cheese")
                {
                    countChees++;
                }
                else if (products == "tomato sauce")
                {
                    countSouce++;
                }
                else if (products == "salami")
                {
                    countSalami++;
                }
                else if (products == "pepper")
                {
                    countPaper++;
                }
            }

            countChees = countChees * 500;
            countPaper = countPaper * 50;
            countSalami = countSalami * 600;
            countSouce = countSouce * 150;
            var totalCalories = countSouce + countSalami + countPaper + countChees;
            Console.WriteLine("Total calories: {0}",totalCalories);
        }
    }
}
