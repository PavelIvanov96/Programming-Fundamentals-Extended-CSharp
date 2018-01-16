using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentRecord = new Dictionary<string, List<double>>();

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                string name = input[0];
                var grade = double.Parse(input[1]);

                if (!studentRecord.ContainsKey(name))
                {
                    studentRecord[name] = new List<double>();
                }
                studentRecord[name].Add(grade);
            }
            foreach (var name in studentRecord)
            {
                Console.WriteLine("{0} -> {1:F2} (avg: {2:f2})" ,
                    name.Key,string.Join(" ",name.Value.Select(p => string.Format("{0:f2}",p))),
                    name.Value.Average());
            }
            
        }
    }
}
