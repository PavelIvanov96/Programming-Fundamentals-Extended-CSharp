using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

           var check = false;

            if (word.EndsWith("y"))
            {
                check = true;
                if (check == true)
                {
                    word = word.Remove(word.Length - 1);
                    Console.WriteLine("{0}ies", word);
                }
            }
            
            else if (word.EndsWith("o"))
            {
                check = true;
                if (check == true)
                {
                      Console.WriteLine("{0}es", word);
                }
            }
            else if (word.EndsWith("ch"))
            {
                check = true;
                if (check == true)
                {
                      Console.WriteLine("{0}es", word);
                }
            }
            else if (word.EndsWith("s"))
            {
                check = true;
                if (check == true)
                {
                     Console.WriteLine("{0}es", word);
                }
            }
            else if (word.EndsWith("sh"))
            {
                check = true;
                if (check == true)
                {
                     Console.WriteLine("{0}es", word);
                }
            }
            else if (word.EndsWith("x"))
            {
                check = true;
                if (check == true)
                {
                      Console.WriteLine("{0}es", word);
                }
            }
            else if (word.EndsWith("z"))
            {
                check = true;
                if (check == true)
                {
                     Console.WriteLine("{0}es", word);
                }
            }
            else
            {
                 Console.WriteLine("{0}s", word);
            }
        }
    }
}
