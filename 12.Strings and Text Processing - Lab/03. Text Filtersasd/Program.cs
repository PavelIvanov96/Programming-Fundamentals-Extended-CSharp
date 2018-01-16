using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filtersasd
{
    class Program
    {
        static void Main(string[] args)
        {
            var banned = Console.ReadLine().Split(',').Select(x => x.Trim());
            var text = Console.ReadLine();

            foreach (var  item in banned)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
