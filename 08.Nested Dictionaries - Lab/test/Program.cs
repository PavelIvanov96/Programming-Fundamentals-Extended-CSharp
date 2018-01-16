using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            var conConCity = new Dictionary<string, Dictionary<string, List<string>>>();
               conConCity["eroupe"] = new Dictionary<string, List<string>>();
               conConCity["eroupe"]["bulgariq"] = new List<string>();
               
               conConCity["eroupe"]["bulgariq"].Add("sofiq");
               conConCity["eroupe"]["bulgariq"].Add("izvos");
             
           
           
               foreach (var continent in conConCity.Keys)
               {
                  // Console.WriteLine("{0} ",continent);
                   foreach (var item in conConCity[continent].Keys)
                   {
                       Console.WriteLine("{0} - {1} ",continent,item);
                       foreach (var city in conConCity[continent].Values)
                       {
                           Console.WriteLine("{0}",string.Join(" ",city));
                       }
                   }   
             }
        }
    }
}
