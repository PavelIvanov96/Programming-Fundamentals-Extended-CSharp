using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Nested_Dictionaries___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();

            // AddGrade(grades, "Gosho", 5);
            // AddGrade(grades, "Pesho", 3);
            grades["Gosho"] = new List<int>();
            grades["Gosho"].Add(5);
            grades["Gosho"].Add(2);
            grades["Gosho"].Add(3);

            grades["Pesho"] = new List<int>();
            grades["Pesho"].Add(3);
            grades["Pesho"].Add(4);

            foreach (var nameAndGrade in grades)
            {
                Console.WriteLine("{0} -> {1}",nameAndGrade.Key,string.Join(" ",nameAndGrade.Value));
            }

            NewMethod(grades);
        }

        private static void NewMethod(Dictionary<string, List<int>> grades)
        {
            foreach (var name in grades.Keys)
            {
                Console.WriteLine("Grades of " + name + ":");
                foreach (var grade in grades[name])
                {
                    Console.WriteLine(grade);
                }
            }
        }
        // public static void AddGrade(Dictionary<string, List<int>> grades, string name, int grade )
        // {
        //     if (! grades.ContainsKey(name))
        //     {
        //         grades[name] = new List<int>();
        //     }
        //     grades[name].Add(grade);
        // }
    }
}
