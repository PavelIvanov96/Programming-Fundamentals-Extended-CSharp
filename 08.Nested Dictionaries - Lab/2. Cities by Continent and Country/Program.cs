using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            //   int n = int.Parse(Console.ReadLine());
            // var conConCity = new Dictionary<string, Dictionary<string, List<string>>>();
            //    conConCity["eroupe"] = new Dictionary<string, List<string>>();
            //    conConCity["eroupe"]["bulgariq"] = new List<string>();
            //    
            //    conConCity["eroupe"]["bulgariq"].Add("sofiq");
            //    conConCity["eroupe"]["bulgariq"].Add("izvos");
            //   // conConCity["eroupe"]["surbiq"] = new List<string>();
            //   // conConCity["eroupe"]["surbiq"].Add("zaicher");
            //
            //
            //    foreach (var continent in conConCity.Keys)
            //    {
            //       // Console.WriteLine("{0} ",continent);
            //        foreach (var item in conConCity[continent].Keys)
            //        {
            //            Console.WriteLine("{0} - {1} ",continent,item);
            //            foreach (var city in conConCity[continent].Values)
            //            {
            //                Console.WriteLine("{0}",string.Join(" ",city));
            //            }
            //        }   
            //  }

            int n = int.Parse(Console.ReadLine());
            var conConCity = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');


                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!conConCity.ContainsKey(continent))
                {
                    conConCity[continent] = new Dictionary<string, List<string>>();
                }
                if (!conConCity[continent].ContainsKey(country))
                {
                    conConCity[continent][country] = new List<string>();
                }
                conConCity[continent][country].Add(city);
                
            }
            foreach (var contin in conConCity)
                {
                    Console.WriteLine("{0}:",contin.Key);
                    foreach (var item in contin.Value)
                    {
                    Console.WriteLine("   {0} -> {1}",item.Key, string.Join(", ",item.Value));
                    }
                }
        }
    }
}
