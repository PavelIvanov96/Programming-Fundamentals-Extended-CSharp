using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {

            var res = "";
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "collapse")
                {
                    break;
                }
                var contein = Console.ReadLine();
                while (true)
                {
                    foreach (var item in input)
                    {
                        
                        if (item.ToString() != contein)
                        {
                            res += item;
                        }
                        else
                        {
                            if (contein.Length <= 1)
                            {
                                break;
                            }
                            contein = contein.Substring(1, contein.Length - 2);
                        }
                    }
                    break;
                }
                Console.Write(res);
                

            }
        }
    }
}
