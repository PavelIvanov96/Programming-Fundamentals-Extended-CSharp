using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeter = ".,:;()[]\"'/\\!? ".ToCharArray();
            string[] words = Console.ReadLine().ToLower()
                .Split(delimeter,StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5).OrderBy(w => w).ToArray();

            Console.WriteLine(string.Join(", ",words));
        }
    }
}
