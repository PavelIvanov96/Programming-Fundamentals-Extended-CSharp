using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var smile = @"(:\))|(:D)|(;\))|(:\*)|(:])|(;])|(:})|(;})|(\(:)|(\*:)|(c:)|(\[:)|(\[;)";
            var sad = @"(:\()|(D:)|(;\()|(:\[)|(;\[)|(:{)|(;{)|(\):)|(:c)|(]:)|(];)";
            var input = Console.ReadLine();
            var matchSmile = Regex.Matches(input, smile);
            var matchSad = Regex.Matches(input, sad);

            var cntSmile = 0;
            var cntSad = 0;

            foreach (Match item in matchSmile)
            {
                cntSmile++;
            }
            foreach (Match item in matchSad)
            {
                cntSad++;
            }
            var smileIndex = (double)cntSmile / cntSad;
            var token = "";
            if (smileIndex >= 2)
            {
                token = ":D";
            }
            else if (smileIndex > 1)
            {
                token = ":)";
            }
            else if (smileIndex == 1)
            {
                token = ":|";
            }
            else if (smileIndex < 1)
            {
                token = ":(";
            }

            Console.WriteLine("Happiness index: {0:f2} {1}", smileIndex, token);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", cntSmile, cntSad);
        }
    }
}
