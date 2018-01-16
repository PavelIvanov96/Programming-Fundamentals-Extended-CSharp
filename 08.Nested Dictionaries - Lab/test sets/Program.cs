using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_sets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            HashSet<string> set = new HashSet<string>();

            list.Add("Sofia");
            list.Add("Plovdiv");
            list.Add("Burgas");
            list.Add("Plovdiv");

            Console.WriteLine(string.Join(" ", list));                               
                                                                                     
            set.Add("Sofia");                                                        
            set.Add("Plovdiv");                                                      
            set.Add("Burgas");                                                       
            set.Remove("Sofia");                                                     
            set.Add("Plovdiv");                                                      
            Console.WriteLine(string.Join(" ", set));                                
            }                                                                        
    }                                                                                
}
