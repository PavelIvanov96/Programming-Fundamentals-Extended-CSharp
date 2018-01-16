using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var patterDigits = @"(\+?\-?[0-9]+\.?[0-9]*)";
            var input = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            input =  input.OrderBy(x => x).ToList();

            foreach (var item in input)
            {
                var matches = Regex.Matches(item,patterDigits);
                var sum = 0;
                var sumDamage = 0.0;
                var res = 0.0;
                var cntMulty = 1;
                var cntDivide = 1;
                foreach (var @char in item)
                {
                    if (@char == '*')
                    {
                        cntMulty++;
                    }
                    else if (@char == '/')
                    {
                        cntDivide++;
                    }
                }
                foreach (Match digit in matches)
                {
                    
                    var num = digit.ToString();
                    if (num[0] == '-')
                    {
                        num = num.Substring(1).ToString(); ;
                         res = double.Parse(num) * - 1;
                        
                    }
                    else if (num[0] == '+')
                    {
                        num = num.Substring(1).ToString();
                         res = double.Parse(num);
                    }
                    else
                    {
                         res = double.Parse(num);
                    }
                    sumDamage += res;
                    
                }
                for (int i = 1; i < cntMulty; i++)
                {
                    sumDamage *= 2;
                }
                for (int i = 1; i < cntDivide; i++)
                {
                    sumDamage /= 2;
                }
                foreach (var letter in item)
                {
                    if (letter != '+' && letter != '-' && letter != '*' && letter != '/' && !char.IsDigit(letter) && letter != '.' )
                    {
                        sum += (int)letter;
                    }
                }
                Console.WriteLine("{0} - {1} health, {2:f2} damage",item,sum,sumDamage);
            }
            
        }
    }
}
