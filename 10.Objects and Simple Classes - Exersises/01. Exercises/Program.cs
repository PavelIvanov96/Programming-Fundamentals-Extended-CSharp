using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var asd = new Exercise() ;
            asd.Topic = "asd";

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] {" -> " },StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "go go go")
                {
                    break;
                }

                var topic = input[0];
                var courseName = input[1];
                var judgeContestLink = input[2];
                var problems = input[3].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                var topicRes = new Exercise();
                topicRes.Topic = topic;

                var courseNameRes = new Exercise();
                courseNameRes.CourseName = courseName;

                var judge = new Exercise();
                judge.JudgeContestLink = judgeContestLink;

                var problemsRes = new Exercise();
                problemsRes.Problems = new List<string>();
                foreach (var problem in problems)
                {
                    problemsRes.Problems.Add(problem);
                }
                var count = 0;
                Console.WriteLine("Exercises: {0}",topicRes.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.",courseNameRes.CourseName);
                Console.WriteLine("Check your solutions here: {0}",judge.JudgeContestLink);
                foreach (var item in problemsRes.Problems)
                {
                    count++;
                    Console.WriteLine("{0}. {1}",count,item);
                }
            }
        }
    }
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }
}
