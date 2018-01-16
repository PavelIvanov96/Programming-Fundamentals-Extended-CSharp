using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().
                Split(new[] {' ',',' ,';', ':' ,'.' ,'!','(', ')', '"', '\'' ,'\\' ,'/' ,'[', ']' },
                StringSplitOptions.RemoveEmptyEntries).
            ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();    
            List<string> elseCase = new List<string>();
            
            for (int i = 0; i < words.Count; i++)
            {
                
                if (words[i].All(char.IsUpper))
                {
                    upperCase.Add(words[i]);
                }
                else if (words[i].All(char.IsLower))
                {
                    lowerCase.Add(words[i]);
                }
                else
                {
                    elseCase.Add(words[i]);
                }
            }
            Console.Write("Lower-case: ");
            Console.WriteLine(String.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(String.Join(", ", elseCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(String.Join(", ", upperCase));
        }
    }
}
