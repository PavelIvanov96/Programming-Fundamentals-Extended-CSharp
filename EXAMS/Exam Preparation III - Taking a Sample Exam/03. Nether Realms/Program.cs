using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "asd2";
            var s = "";
            var isdigit = false;
            var c = "";
            for (int i = 0; i < 3; i++)
            {
                c = s + c;
            }
            Console.WriteLine(c);
            foreach (var item in str)
            {
                int a;
                
             var res = int.TryParse(item.ToString() ,out a);
                if (res)
                {
                    isdigit = true;
                }
                else
                {
                    s += item.ToString().ToUpper();
                    Console.WriteLine(s);
                    if (isdigit)
                    {
                        
                    }
                }
                for (int i = 0; i < a; i++)
                {
                    c = s + c;
                }

            }
            Console.WriteLine(c);


        }
    }
}
