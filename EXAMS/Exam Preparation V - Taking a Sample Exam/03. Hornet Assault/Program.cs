using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).ToList();
            var hornets = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).ToList();

            

            for (int i = 0; i < beehives.Count ; i++)
            {
                var sum = 0L;
                if (hornets.Count <=0)
                {
                    break;
                }
                foreach (var item in hornets)
                {
                    sum += item;
                }
                if (sum > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] = beehives[i] - sum;
                    hornets.RemoveAt(0);
                }
            }
            if (beehives.Any(bh => bh > 0))
            {
               Console.WriteLine(string.Join(" ",beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
        }
    }
}
