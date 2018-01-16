using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var dic = new Dictionary<string, string>();

            var count = 0;

            while (input[0] != "login")
            {
                dic[input[0]] = input[2];
                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "end")
            {
                if (dic.ContainsKey(input[0]) && dic.ContainsValue(input[2]))
                {
                    Console.WriteLine("{0}: logged in successfully",input[0]);
                }
                else
                {
                    Console.WriteLine("{0}: login failed",input[0]);
                    count++;
                }
                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine("unsuccessful login attempts: {0}",count);
        }
    }
}
