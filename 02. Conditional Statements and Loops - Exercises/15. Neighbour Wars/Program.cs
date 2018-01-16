using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            var count = 1;
            var peshoHealth = 100;
            var goshoHealth = 100;
            string name = "";
            while (true)
            {
                
                if (count % 2 == 1 )
                {
                    goshoHealth = goshoHealth - peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                    }
                }
                else
                {
                    peshoHealth = peshoHealth - goshoDamage;
                    if (peshoHealth > 0)
                    {
                       Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                    }
                }
                if (peshoHealth <= 0 || goshoHealth <= 0)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", count);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pesho won in {0}th round.",count);
                        break;   
                    }
                    
                }

                if (count % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                count++;
            }
        }
    }
}
