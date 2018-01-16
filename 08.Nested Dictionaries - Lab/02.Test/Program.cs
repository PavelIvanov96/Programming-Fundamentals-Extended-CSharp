using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // country_code -> town -> population

            var population = new Dictionary<string, Dictionary<string, int>>();
            population["Bulgaria"] = new Dictionary<string, int>();
            population["Bulgaria"]["Sofia"] = 1200000;
            population["Bulgaria"]["Plovdiv"] = 700000;

            population["Germany"] = new Dictionary<string, int>();
            population["Germany"]["Munich"] = 2500000;
            population["Germany"]["Berlin"] = 1500000;


            
            foreach (var country in population.Keys)
            {
                Console.WriteLine("Country {0}: ",country);
                foreach (var town in population[country].Keys)
                {
                    Console.WriteLine("  {0} -> {1} citizens",town ,population[country][town]);
                }
            }
        }

      
    }
}
