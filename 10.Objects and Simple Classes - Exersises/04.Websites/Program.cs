using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> websites = new List<Website>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] {" | "},StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }

                var host = input[0];
                var domain = input[1];
                
                if (input.Length <= 2)
                {
                    var newWeb = new Website()

                    {
                        Host = host,
                        Domain = domain,
                        Queries = null
                   };
                    websites.Add(newWeb);
                }
                else
                {
                    var queries = input[2].Split(',').ToList();
                    var newWebs = new Website()
                        {
                            Host = host,
                            Domain = domain,
                            Queries = queries
                      };
                    websites.Add(newWebs);
                }
            }
           
            foreach (var web in websites)
            {
                if (web.Queries == null)
                {
                  Console.WriteLine($"https://www.{web.Host}.{web.Domain}");
                }
                else
                {
                    Console.Write($"https://www.{web.Host}.{web.Domain}/query?=");

                    var count = 0;
                    foreach (var item in web.Queries)
                    {
                        if (count == web.Queries.Count -1)
                        {
                            Console.Write("[{0}]", item);
                        }
                        else
                        {
                            Console.Write("[{0}]&", item);
                        }
                        count++;
                    }
                    Console.WriteLine();
                }

            }
        }
    }
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }
}
